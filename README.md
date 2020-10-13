# Fizz Buzz MVC
This is a port of the JavaScript challenge FizzBuzz demonstrating working with arrays and If/Else logic using a simple MVC design pattern

for more of my work check out my **[portfolio](https://adrianedelen.com)**
### the main Logic 
```csharp
public IActionResult Solve(string input1, string input2, string input3, string input4)
        {
            var min = Convert.ToInt32(input1);
            var max = Convert.ToInt32(input2);
            var fizz = Convert.ToInt32(input3);
            var buzz = Convert.ToInt32(input4);
            var output = new StringBuilder();
            for (int i = min; i <= max; i++)
            {
                if (i % fizz == 0 && i % buzz == 0)
                {
                    output.Append("FizzBuzz ");
                } 
                else if (i % fizz == 0)
                {
                    output.Append("Fizz ");
                } 
                else if (i % buzz == 0)
                {
                    output.Append("Buzz ");
                } 
                else
                {
                    output.AppendLine(i.ToString());
                }
            }
            ViewData["Output"] = output.ToString();
            return View();
        }
```
