using ExpertSystem.KnowledgeBaseDomain;
using Newtonsoft.Json;

namespace ExpertSystem.ExpertSystemShellDomain;

public class ExpertSystemShell
{
    public KnowledgeBase KnowledgeBase { get; private set; }
    private InferentialMechanism InferentialMechanism { get; set; }
    private readonly WorkingMemory _workingMemory;
    private readonly IExpertSystemIo _io;

    public ExpertSystemShell()
    {
        _workingMemory = new WorkingMemory();
        _io = new FormsIo();
        KnowledgeBase = new KnowledgeBase();
        InferentialMechanism = new InferentialMechanism(KnowledgeBase, _workingMemory, _io);
    }

    public bool LoadKnowledgeBase(string path)
    {
        var knowledgeBaseJson = File.ReadAllText(path);
        var deserializedKnowledgeBase = JsonConvert.DeserializeObject<KnowledgeBase>(
            knowledgeBaseJson,
            new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });

        if (deserializedKnowledgeBase is null)
        {
            return false;
        }
        
        KnowledgeBase = deserializedKnowledgeBase;
        InferentialMechanism = new InferentialMechanism(KnowledgeBase, _workingMemory, _io);
        return true;
    }

    public bool SaveKnowledgeBase(string path)
    {
        try
        {
            // TODO bin save
            string knowledgeBaseJson = JsonConvert.SerializeObject(KnowledgeBase, Formatting.Indented, 
                new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            File.WriteAllText(path, knowledgeBaseJson);
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }

    public void CreateEmptyKnowledgeBase()
    {
        KnowledgeBase = new KnowledgeBase();
        InferentialMechanism = new InferentialMechanism(KnowledgeBase, _workingMemory, _io);
    }

    public void Infer(Variable targetVariable)
    {
        _workingMemory.FiredRules.Clear();
        _workingMemory.VariableValues.Clear();
        
        InferentialMechanism.StartInference(targetVariable);
    }
}