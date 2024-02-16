using System;
using System.ComponentModel.DataAnnotations;

namespace PrepaidMerchantAPI.Entities
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public decimal TransactionAmount { get; set; }
        public string TerminalId { get; set; }
        public string ReferenceNumber { get; set; }
        public TranStatus TransactionStatus { get; set; }
        public bool isSuccessful => TransactionStatus.Equals(TranStatus.Approved);
        public TranType TransactionType { get; set; }
        public string MerchantInfo { get; set; }
        public DateTime TransactionDate { get; set; }

        //public Transaction()
        //{
        //    TerminalId = $"#{Guid.NewGuid().ToString().Replace("-", "").Substring(1, 10)}";

        //    Random random = new Random();
        //    int randomNumber = random.Next(100000, 999999); 
        //    string reference = $"Ref{randomNumber}";

        //    ReferenceNumber = reference;
       
        //}
    }

    public enum TranStatus
    {
       Approved,
       Failed
    }
    public enum TranType
    {
       Income,
       Outcome
    }
}

