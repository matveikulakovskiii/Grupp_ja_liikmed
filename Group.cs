using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp_ja_liikmed
{
    public class Group
    {
        public List<string> Members { get; } = new List<string>();
        private readonly int _maxAmount;
        public List<Type> Types { get; } = new List<Type>();

        public Group(int maxAmount)
        {
            _maxAmount = maxAmount;
        }

        public bool AddMember(string member)
        {
            if (Members.Contains(member)) return false;
            if (Members.Count >= _maxAmount) return false;
            Members.Add(member);
            return true;
        }

        public int GetMembersCount()
        {
            return Members.Count;
        }

        public bool HasMember(string member)
        {
            return Members.Contains(member);
        }

        public Type Oldest()
        {
            if (Types.Count == 0) return null;
            return Types.OrderBy(t => t.Age).Last();
        }

        public Type Youngest()
        {
            if (Types.Count == 0) return null;
            return Types.OrderBy(t => t.Age).First();
        }
    }
}



