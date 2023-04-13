using Mocker.Interfaces;

namespace Mocker
{
    public class BaseMap : IBaseMap
    {
        internal IList<IRuleSet> RuleSets { get; set; }
        IList<IRuleSet> IBaseMap.RuleSets { get => RuleSets; }
        public BaseMap()
        {
            RuleSets = new List<IRuleSet>();
        }
        public RuleSet<T> RuleSet<T>()
        {
            var ruleSet = new RuleSet<T>();
            RuleSets.Add(ruleSet);
            return ruleSet;
        }
    }
}
