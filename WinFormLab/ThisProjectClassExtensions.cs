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
  /// 讓非同步函式以同步執行。Refit 現在只支援非同步溝通。
  /// </summary>
  public static T RunSync<T>(Func<Task<T>> taskFuncAsync)
  {
    return Task.Run(async () => await taskFuncAsync.Invoke())
        .GetAwaiter()
        .GetResult();
  }
}
