//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MODEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_TaskParticipation
    {
        public int TaskId { get; set; }
        public string TaskReceiver { get; set; }
        public string TaskGrade { get; set; }
        public bool IsRead { get; set; }
        public bool IsComplete { get; set; }
        public string TaskResponse { get; set; }
        public string StandA { get; set; }
        public string StandB { get; set; }
    
        public virtual T_MemberInformation T_MemberInformation { get; set; }
        public virtual T_TaskInformation T_TaskInformation { get; set; }
    }
}
