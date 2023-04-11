You have four tasks: to implement the logic for determining if the above actions are available based on the state of the three characters found in the forest and whether Annalyn's pet dog is present or not.

Task 1
Check if a fast attack can be made

Implement the (static) QuestLogic.CanFastAttack() method that takes a boolean value that indicates if the knight is awake. This method returns true if a fast attack can be made based on the state of the knight. Otherwise, returns false:

var knightIsAwake = true;
QuestLogic.CanFastAttack(knightIsAwake);
// => false

Task 2
Check if the group can be spied upon

Implement the (static) QuestLogic.CanSpy() method that takes three boolean values, indicating if the knight, archer and the prisoner, respectively, are awake. The method returns true if the group can be spied upon, based on the state of the three characters. Otherwise, returns false:

var knightIsAwake = false;
var archerIsAwake = true;
var prisonerIsAwake = false;
QuestLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake);
// => true

Task 3
Check if the prisoner can be signalled

Implement the (static) QuestLogic.CanSignalPrisoner() method that takes two boolean values, indicating if the archer and the prisoner, respectively, are awake. The method returns true if the prisoner can be signalled, based on the state of the two characters. Otherwise, returns false:

var archerIsAwake = false;
var prisonerIsAwake = true;
QuestLogic.CanSignalPrisoner(archerIsAwake, prisonerIsAwake);
// => true

Task 4
Check if the prisoner can be freed

Implement the (static) QuestLogic.CanFreePrisoner() method that takes four boolean values. The first three parameters indicate if the knight, archer and the prisoner, respectively, are awake. The last parameter indicates if Annalyn's pet dog is present. The method returns true if the prisoner can be freed based on the state of the three characters and Annalyn's pet dog presence. Otherwise, it returns false:

var knightIsAwake = false;
var archerIsAwake = true;
var prisonerIsAwake = false;
var petDogIsPresent = false;
QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent);
// => false

When a test fails, a message is displayed describing what went wrong and for which input. You can also use the fact that any console output will be shown too. You can write to the console using:

Console.WriteLine("Debug message");
