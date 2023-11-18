
using Autoservice_Back.Models;

namespace Autoservice_Back.Interfaces
{
    public interface IOrdersWithoutReg
    {
        void AddOrderWithoutReg(OrderWithoutReg orderWithoutReg);
    }
}
