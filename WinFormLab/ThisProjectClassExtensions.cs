using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormLab;

internal static class ThisProjectClassExtensions
{

}

internal static class RefitHelper
{
  /// <summary>
  /// 讓非同步 async 函式以 await 同步執行並送回執行結果。
  /// 因為 Refit 現在只支援非同步溝通。
  /// </summary>
  /// <remarks>
  /// return Task.Run(async () => await WeatherForecastAsync(args)).GetAwaiter().GetResult();
  /// 上例的語法糖衣之一般化
  /// </remarks>
  public static T RunSync<T>(Func<Task<T>> taskFuncAsync)
  {
    return Task.Run(async () => await taskFuncAsync.Invoke())
        .GetAwaiter()
        .GetResult();
  }
}
