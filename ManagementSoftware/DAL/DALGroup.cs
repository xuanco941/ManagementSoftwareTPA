using ManagementSoftware.Models;

namespace ManagementSoftware.DAL
{
    public class DALGroup
    {

        // Hàm thêm mới một đối tượng Group vào database
        public void Add(Group group)
        {
            using (var context = new DataBaseContext())
            {
                context.Groups.Add(group);
                context.SaveChanges();
            }
        }

        // Hàm lấy tất cả các đối tượng Group trong database
        public List<Group> GetAll()
        {
            using (var context = new DataBaseContext())
            {
                return context.Groups.ToList();
            }
        }

        // Hàm lấy một đối tượng Group theo GroupID
        public Group? GetById(int groupId)
        {
            using (var context = new DataBaseContext())
            {
                return context.Groups.FirstOrDefault(g => g.GroupID == groupId);
            }
        }

        // Hàm cập nhật thông tin một đối tượng Group
        public void Update(Group group)
        {
            using (var context = new DataBaseContext())
            {
                var existingGroup = context.Groups.FirstOrDefault(g => g.GroupID == group.GroupID);
                if (existingGroup != null)
                {
                    // Cập nhật thuộc tính của đối tượng Group
                    existingGroup.GroupName = group.GroupName;
                    existingGroup.IsManagementUser = group.IsManagementUser;
                    existingGroup.IsManagementMachine = group.IsManagementMachine;

                    context.SaveChanges();
                }
            }
        }

        // Hàm xóa một đối tượng Group khỏi database
        public void Delete(int groupId)
        {
            using (var context = new DataBaseContext())
            {
                var groupToDelete = context.Groups.FirstOrDefault(g => g.GroupID == groupId);
                if (groupToDelete != null)
                {
                    context.Groups.Remove(groupToDelete);
                    context.SaveChanges();
                }
            }
        }

    }
}
