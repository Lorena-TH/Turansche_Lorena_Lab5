using System.Threading.Tasks;
using Turansche_Lorena_Lab5.Models;
namespace Turansche_Lorena_Lab5.Services

{
    public interface IRiskPredictionService
    {
        Task<String> PredictRiskAsync(RiskInput input);
    }
}
