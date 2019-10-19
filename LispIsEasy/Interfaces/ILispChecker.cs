using LispIsEasy.BusinessObjects;
using System.Threading.Tasks;

namespace LispIsEasy.Interfaces
{
    public interface ILispChecker
    {
        bool CheckExpression(LispExpression expression);
    }
}
