using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerService:IEntities
    {
        void Save(Customer customer);
    }
}
