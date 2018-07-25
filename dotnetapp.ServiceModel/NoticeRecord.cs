using System;
using ServiceStack;

namespace dotnetapp.ServiceModel
{
    public class NoticeRecord: IReturn<NoticeRecordResponse>
    {
        public Pocos.NoticeRecord record { get; set; }

        public NoticeRecord()
        {
            this.record = new Pocos.NoticeRecord { NoticeRecordId = new Guid(), DateCreated = new DateTime(), IsActive = true, LocationId = new Guid() };
        }
    }

    public class NoticeRecordResponse
    {
        public string Result { get; set; }
    }
}
