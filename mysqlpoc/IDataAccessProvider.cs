﻿using System;
using System.Collections.Generic;

namespace mysqlpoc
{
    public interface IDataAccessProvider
    {
        void AddDataEventRecord(DataEventRecord dataEventRecord);
        void UpdateDataEventRecord(long dataEventRecordId, DataEventRecord dataEventRecord);
        void DeleteDataEventRecord(long dataEventRecordId);
        DataEventRecord GetDataEventRecord(long dataEventRecordId);
        List<DataEventRecord> GetDataEventRecords();
        List<SourceInfo> GetSourceInfos(bool withChildren);
    }
}
