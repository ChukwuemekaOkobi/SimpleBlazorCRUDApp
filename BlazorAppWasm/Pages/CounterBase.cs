using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppWasm.Pages
{
    public  class CounterBase: ComponentBase
    {

        public int currentCount = 0;

        public void IncrementCount()
        {
            currentCount++;
        }
    }


}
