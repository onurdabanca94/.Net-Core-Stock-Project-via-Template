using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.MvcWebUI.Models.Services
{
    public interface IMailService
    {
        void Send(EmailMessage emailMessage);
    }
}
