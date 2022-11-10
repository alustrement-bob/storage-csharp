﻿using Supabase.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Storage.Interfaces
{
    public interface IStorageBucketApi<TBucket>
        where TBucket : Bucket
    {
        Dictionary<string, string> Headers { get; set; }

        Task<string> CreateBucket(string id, BucketUpsertOptions? options = null);
        Task<GenericResponse?> DeleteBucket(string id);
        Task<GenericResponse?> EmptyBucket(string id);
        Task<TBucket?> GetBucket(string id);
        Task<List<TBucket>?> ListBuckets();
        Task<TBucket?> UpdateBucket(string id, BucketUpsertOptions? options = null);
    }
}