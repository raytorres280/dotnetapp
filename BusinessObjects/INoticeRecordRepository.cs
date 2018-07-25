using System;
using System.Collections.Generic;

namespace dotnetapp.ServiceInterface
{
    public interface INoticeRecordRepository: IRepository<NoticeRecord>
    {
        IEnumerable<NoticeRecord> GetActiveRecords();
        IEnumerable<NoticeRecord> GetRecordsInDateRage(DateTime start, DateTime end);
    }
}
