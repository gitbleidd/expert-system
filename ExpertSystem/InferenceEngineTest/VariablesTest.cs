using ExpertSystemShellDomain;
using ExpertSystemShellDomain.Entities;

namespace InferenceEngineTest;

public class VariablesTest
{
    private KnowledgeBase _knowledgeBase;
    private WorkingMemory _workingMemory;
    private InferentialMechanism _inferentialMechanism;
    
    
    private void InitEngineComponents(TestIo io)
    {
        _knowledgeBase = InitKnowledgeBase.KnowledgeBase;
        _workingMemory = new WorkingMemory();
        _inferentialMechanism = new InferentialMechanism(_knowledgeBase, _workingMemory, io);
    }
    
    [Fact]
    public void RussianLevelTest()
    {
        // RUSBAL, IZLOJ, LITBAL, READSPD, BOOKCNT
        var inputData = new int[][]
        {
            new[] { 0, 1, 0, 0, 0 },
            new[] { 0, 1, 1, 1, 0 },
            new[] { 0, 1, 1, 1, 2 },
            new[] { 1, 0, 0, 0, 0 },
            new[] { 1, 1, 1, 0, 3 },
            new[] { 0, 0, 1, 1, 3 },
            new[] { 2, 0, 0, 0, 0 },
            new[] { 2, 0, 0, 1, 3 },
            new[] { 2, 0, 1, 1, 3 }
        };
        
        // RUSLVL
        var resultData = new int[] { 0, 1, 1, 1, 1, 2, 1, 2, 2, };

        var variable = InitKnowledgeBase.RUSLVL_variable;
        TestVariable(inputData, resultData, variable);
    }

    [Fact]
    public void ForeignLanguageLevelTest()
    {
        // LNGCNT, LNGBEG, LNGDROP, TALKEXP, FRNLIT, MSCUND
        var inputData = new int[][]
        {
            new[] { 1, 0, 1, 0, 0, 0 },
            new[] { 2, 0, 1, 2, 1, 0 },
            new[] { 1, 0, 1, 2, 1, 2 },
            new[] { 1, 1, 1, 0, 0, 0 },
            new[] { 1, 1, 1, 0, 1, 1 },
            new[] { 2, 0, 0, 2, 1, 2 },
            new[] { 2, 1, 0, 0, 0, 0 },
            new[] { 2, 1, 0, 1, 1, 1 },
            new[] { 1, 1, 0, 2, 1, 2 },
            new[] { 0 }, // Non-inferred variable test
        };
        
        // FRNLLVL
        var resultData = new int[] { 1, 2, 2, 2, 2, 3, 2, 3, 3, 0 };

        var variable = InitKnowledgeBase.FRNLLVL_variable;
        TestVariable(inputData, resultData, variable);
    }

    [Fact]
    public void PsychoBarTest()
    {
        // SELFEDU, FRNCULT, DLGHARD, NERVOUS, EXPROMT
        var inputData = new int[][]
        {
            new[] { 0, 0, 0, 0, 2 },
            new[] { 0, 1, 1, 1, 1 },
            new[] { 0, 0, 1, 1, 0 },
            new[] { 1, 0, 0, 0, 2 },
            new[] { 1, 0, 0, 0, 0 },
            new[] { 1, 0, 1, 1, 0 },
            new[] { 1, 1, 0, 0, 2 },
            new[] { 1, 1, 1, 0, 0 },
            new[] { 1, 1, 1, 1, 0 },
        };
        
        // PSYBAR
        var resultData = new int[] { 2, 2, 1, 1, 1, 1, 0, 1, 1 };

        var variable = InitKnowledgeBase.PSYBAR_variable;
        TestVariable(inputData, resultData, variable);
    }
    
    [Fact]
    public void IndividualQualitiesTest()
    {
        // SEX, AGE, POEMLVL, FACTLVL, DIARY, VOCAL, HEARING
        var inputData = new int[][]
        {
            new[] {0, 0, 0, 0, 1, 0, 0},
            new[] {0, 1, 0, 0, 1, 0, 1},
            new[] {0, 0, 1, 1, 1, 0, 0},
            new[] {0, 1, 0, 1, 0, 0, 1},
            new[] {0, 0, 1, 1, 0, 0, 0},
            new[] {0, 1, 1, 1, 0, 1},
            new[] {1},
            new[] {0, 2},
        };
        
        // QLTLVL
        var resultData = new int[] { 0, 1, 1, 1, 1, 2, 2, 2 };

        var variable = InitKnowledgeBase.QLTLVL_variable;
        TestVariable(inputData, resultData, variable);
    }
    
    [Fact]
    public void LearningPropensityLevelTest()
    {
        var inputData = new int[][]
        {
            new[] { 0, 1, 0, 0, 3, 0, 1, 1, 0, 1, 1, 1 },
            new[] { 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 2, 0, 0, 0, 0, 1, 0, 0 },
            new[] { 2, 0, 1, 1, 3, 0, 1, 1, 0, 0, 2, 0, 1, 1, 1, 0, 0, 1 },
        };
        
        // PREDLVL
        var resultData = new int[] { 1, 0, 1 };

        var variable = InitKnowledgeBase.PREDLVL_variable;
        TestVariable(inputData, resultData, variable);
    }

    private void TestVariable(int[][] inputData, int[] result, Variable targetVariable)
    {
        for (int i = 0; i < inputData.Length; i++)
        {
            var input = inputData[i];
            var resultDomainValueIndex = result[i];
            InitEngineComponents(new TestIo(input));
            
            _inferentialMechanism.StartInference(targetVariable);
            Assert.Equal(targetVariable.Domain.Values[resultDomainValueIndex], _workingMemory.VariableValues[targetVariable]);
        }
    }
}