# Kata Instructions

This was set up for a [Digital Solutions](https://www.hidigital.solutions/) "Team Learning" session.  There are about 10 people in our team learning sessions.  We all do our text editing a little different.  I think we all mostly use VSCode day-to-day, but with different habits and some with different keybindings.

Here's the plan:  for each of the exercises listed below, we'll have at least 2 people demonstrate the task (real-time).  Once they're done, they'll explain anything they did other than basic editing techniques (copy/paste, typing, and arrow keys).  And the rest of the team can ask questions.  If there's anything else to discuss, we might do that too ("gee, how'd you learn to type so fast?", "why'd you choose to copy/paste everything to Notepad, then paste back to VSCode?", etc).  And if there's someone that wants to show off a different technique, we'll give them a chance.  It's not a race or a contest.  The hope is that we'll all learn at least some nugget that will help reduce the friction of editing, so we can spend more time thinking at higher levels.

Enough procedure!  Here are the exercises:

## Warmup:  Add Markdown files to the Azure DevOps pipeline exclusion list

Isn't it a pain when Azure DevOps kicks off a build just because you cleaned up a bit of documentation?  Speaking of "a pain", the pipeline files are a bit of a pain.  Near as we've been able to tell, wildcard exclusions don't work.  Your task is to add the four files under `docs` to the `exclude` section of `azure-pipelines.yml`.

While you're in there, feel free to remove the exclusion for the file that no longer exists.

## Make the Azure DevOps pipeline multi-environment

Now that we're looking at the pipeline, it sure seems like there's nothing environment-specific in *any* of this highly-sophisticated deployment.  

Your task is to remove all references to Dev.

This one is a bit beyond mechanical.  Use your judgment on what exactly to change things to, but don't get hung up on things like what to name your variable group.

## Fix the failing test

There is a failing unit test.  In case you're not set up to run it, it's `ProductionCodeTests.UnitTest1.CanCreateUserRecordWithNullClaims` (the second test).  After extensive analysis, our debugging team has determined that the problem is on lines 37-41.  We need to set all those fields to `null` if we want our `Should().BeNull()` assertions to pass.

Your task is to set all the fields to `null`.

## Add a new test

For some reason, all of these tests were written to use the `ClaimValue` method to set the `UserRecord` fields.  We need to make sure there's nothing that will fail if we just set it to a string.  (Spoiler alert:  it won't fail.  But just...just...okay?)

Your task is to create a new test (`CanCreateUserRecordWithoutUsingClaimValue` seems like a fine name).  It should look a lot like the previous tests.  The `UserRecord` fields should be set to strings (not `null`, not using `ClaimValue`).  The assertions should also be correct (using `Should().Be(...)` is probably best).  Formatting/indentation should be nice and consistent.

## Add some code back in

There is a method in `Program.cs` named `SetUpAUserRecordForSomeReason`.  The code in it is commented out.  It's also wrong, as your compiler will tell you (`UserRecord` does not contain a constructor that takes arguments).

Your task is to have `SetUpAUserRecordForSomeReason` create an `UserRecord` with the values in the commented-out code, and assign it to the variable.  You can decide whether to use initializer syntax (like in the unit tests), a set of assignment statements, or create a constructor.  Each takes enough editing to be a worthwhile exercise.  (And let's be honest, there's nothing in this project that suggests one approach over another.)  If you're not sure, use initializer syntax like in the unit tests.

## Fix list numbering

The list numbers in the [production operation instructions](docs/production-operation.md) will render fine in most Markdown viewers, but there's a number out of sequence (#4, just before #9 "All Done").  And there's a problem.  Someone forgot to include "Call 811 before you dig" after step 1 but before step 2.

Your task is to add the missing step between current steps 1 and 2, then either (your choice):

* Number everything correctly (1, 2, 3, etc.) including the nested list - OR -
* Take advantage of this being markdown and simply number everything as 1.

## Copy, paste, and clean up

From reading the [database setup instructions](docs/database-setup.md), it appears there's a function that needs to be copied and pasted to finish database setup.  No, this really doesn't make sense.  But for the sake of a contrived example, it'll work great.

Your task is to:

1. Copy the function into Program.cs
2. Name it according to the instructions in `database-setup.md`
3. Clean up the comments (assume the code will be maintained by someone who doesn't need comments on `public` vs `private`)
4. Nicely format the code.  Some suggestions:
   * Each LINQ function should be on its own line, starting with the `.`, indented nicely.
   * Exactly one space on either side of the lambda arrow `=>`
   * Exactly one space on either side of equality tests `==`
   * Don't clean up the logic.  At least not yet.  The point of this exercise is text editing, and the code is deliberately bad to give you plenty to edit.
   * Look at a picture of an alpaca after you're done to help cleanse your brain of that hideous code.
