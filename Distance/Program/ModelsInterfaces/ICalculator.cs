using System.Collections.Generic;

namespace DistanceCalculation.ModelsInterfaces
{
    public interface ICalculator
    {
        float Calculate(IEnumerable<IPoint> points);
    }
}
