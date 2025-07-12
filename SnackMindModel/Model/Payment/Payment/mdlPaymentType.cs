using SnackMindCore.BaseClass;

using System.Collections.Generic;

namespace SnackMindModel.Model.Payment.Payment
{
    public class mdlPaymentType : Entity
    {
        public string Name { get; set; }
        public virtual ICollection<mdlPayment> Payments { get; set; }
    }
}