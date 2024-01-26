// IMemberRepository.cs in DataAccess project

using BusinessObject;
using System.Collections.Generic;

namespace DataAccess
{
    public interface IMemberRepository
    {
        List<MemberObject> GetAllMembers();
        MemberObject GetMemberByID(int id);
        void AddMember(MemberObject member);
        void UpdateMember(MemberObject member);
        void DeleteMember(int id);
    }
}
