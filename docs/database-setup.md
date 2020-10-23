# Database Setup

Step 1:  Set up the database
Step 2:  Copying this code into a function in `Program.cs` named `ProcessDatabaseData` would be a good idea, maybe?

```csharp
    private // Don't want other modules to call this
            static // doesn't use instance values
// don't return anything either
void
// the plan is to put them in a class-level variable (unless that's bad design with this vague naming)
        functionnameforprocessingdata(List<UserRecord> records){ var processed
        = records.Where(x=>x.FirstName.ToUpper()
                ==x.FirstName).ToDictionary(x=>x.EmailAddress
                +
                "."
+x.UserId
    ,x=>x).Where(x =>x.Value.EmailAddress.Contains("@")).Select(x=>x.Value).GroupBy(r=>
        r.LastName).Where(g     =>g.Count()==1).Select(g=>g.FirstOrDefault())
        // cool, now do something with processed once The Architect tells us what to do
;// wow, this code is great and so sophisticated!
        }
```
