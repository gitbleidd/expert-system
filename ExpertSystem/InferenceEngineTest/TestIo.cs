using System.Collections;
using ExpertSystemShellDomain;
using ExpertSystemShellDomain.Entities;

namespace InferenceEngineTest;

public class TestIo : IExpertSystemIo
{
    private readonly int[] _testValuesIndexes;
    private readonly IEnumerator<int> _enumerator;

    public TestIo(int[] testValuesIndexes)
    {
        _testValuesIndexes = testValuesIndexes;
        _enumerator = ((IEnumerable<int>)_testValuesIndexes).GetEnumerator();
    }
    
    public void InitIo()
    {
        
    }

    public void ShowMessage(string text, string caption)
    {
        
    }

    public DomainValue? CreateVariableRequest(Variable variable)
    {
        // Test values will be passed to inferior engine
        _enumerator.MoveNext();
        return variable.Domain.Values[_enumerator.Current];
    }
}