using System;

namespace RWPLEntityModel
{
    public interface IEntity
    {
        long SrNo { get; set; }

        string CreatedBy { get; set; }

        DateTime CreatedDate { get; set; }

        string UpdatedBy { get; set; }

        DateTime? UpdatedDate { get; set; }

        bool IsDeleted { get; set; }

        string DeletedBy { get; set; }

        DateTime? DeletedDate { get; set; }

        string DeleteReason { get; set; }

        System.Data.Linq.Binary TimeStamp { get; set; }
    }
}