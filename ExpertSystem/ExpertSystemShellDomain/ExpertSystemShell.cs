using System.Text;
using ExpertSystemShellDomain.Entities;
using Newtonsoft.Json;

namespace ExpertSystemShellDomain;

public class ExpertSystemShell
{
    public KnowledgeBase KnowledgeBase { get; private set; }
    public WorkingMemory WorkingMemory { get; private set; }
    private InferentialMechanism InferentialMechanism { get; set; }
    private readonly IExpertSystemIo _io;

    public ExpertSystemShell(IExpertSystemIo io)
    {
        WorkingMemory = new WorkingMemory();
        _io = io;
        KnowledgeBase = new KnowledgeBase();
        KnowledgeBase = InitKnowledgeBase.KnowledgeBase;
        InferentialMechanism = new InferentialMechanism(KnowledgeBase, WorkingMemory, _io);
    }

    public bool LoadKnowledgeBase(string path)
    {
        string knowledgeBaseJson;
        try
        {
            knowledgeBaseJson = Encoding.Unicode.GetString(Convert.FromBase64String(File.ReadAllText(path)));
        }
        catch (Exception e)
        {
            return false;
        }
        
        var deserializedKnowledgeBase = JsonConvert.DeserializeObject<KnowledgeBase>(
            knowledgeBaseJson,
            new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
        if (deserializedKnowledgeBase is null)
            return false;
        
        KnowledgeBase = deserializedKnowledgeBase;
        InferentialMechanism = new InferentialMechanism(KnowledgeBase, WorkingMemory, _io);
        return true;
    }

    public bool SaveKnowledgeBase(string path)
    {
        try
        {
            string knowledgeBaseJson = JsonConvert.SerializeObject(KnowledgeBase, Formatting.Indented, 
                new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            File.WriteAllText(path, Convert.ToBase64String(Encoding.Unicode.GetBytes(knowledgeBaseJson)));
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    public void CreateEmptyKnowledgeBase()
    {
        KnowledgeBase = new KnowledgeBase();
        InferentialMechanism = new InferentialMechanism(KnowledgeBase, WorkingMemory, _io);
    }

    public void Infer(Variable targetVariable)
    {
        WorkingMemory = new WorkingMemory(targetVariable);
        InferentialMechanism = new InferentialMechanism(KnowledgeBase, WorkingMemory, _io);
        
        InferentialMechanism.StartInference(targetVariable);
    }
}