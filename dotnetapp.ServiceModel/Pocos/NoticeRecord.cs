using System;
namespace dotnetapp.ServiceModel.Pocos
{
    public class NoticeRecord
    {
        public Guid NoticeRecordId { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid LocationId { get; set; }
        public Boolean IsActive { get; set; }
    }
}
