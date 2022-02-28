using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.UserTypes
{
    public class UserTypeDto:AuditedEntityDto<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public bool Active { get; set; }
    }
}

