using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skybrud.Social.LinkedIn
{
    public class LinkedInScopeCollection
    {

        private List<LinkedInScope> _list = new List<LinkedInScope>();

        public LinkedInScopeCollection(params LinkedInScope[] scopes)
        {
            _list.AddRange(scopes);
        }

        public void Add(LinkedInScope scope)
        {
            _list.Add(scope);
        }

        public LinkedInScope[] ToArray()
        {
            return _list.ToArray();
        }

        public string[] ToStringArray()
        {
            return (from scope in _list select scope.Name).ToArray();
        }

        public override string ToString()
        {
            return String.Join(",", from scope in _list select scope.Name);
        }

        public static LinkedInScopeCollection operator +(LinkedInScopeCollection left, LinkedInScope right)
        {
            left.Add(right);
            return left;
        }

    }
}
