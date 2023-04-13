namespace Mocker.Interfaces
{
    public interface IBaseMap
    {
        public IList<IRuleSet> RuleSets { get; }
        public RuleSet<T> RuleSet<T>();
    }
}
