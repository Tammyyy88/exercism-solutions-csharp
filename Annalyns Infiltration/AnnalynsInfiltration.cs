using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return !knightIsAwake;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        // can spy if only the knight is awake
    if (knightIsAwake && !archerIsAwake && !prisonerIsAwake)
    {
        return true;
    }
    
    // can spy if only the archer is awake
    if (!knightIsAwake && archerIsAwake && !prisonerIsAwake)
    {
        return true;
    }
    
    // can spy if only the prisoner is awake
    if (!knightIsAwake && !archerIsAwake && prisonerIsAwake)
    {
        return true;
    }

    if (!knightIsAwake && prisonerIsAwake && archerIsAwake)
    {
        return true;
    }
    
    if (knightIsAwake && prisonerIsAwake && !archerIsAwake)
    {
        return true;
    }

    if (knightIsAwake && !prisonerIsAwake && archerIsAwake)
    {
        return true;
    }

     if (knightIsAwake && prisonerIsAwake && archerIsAwake)
    {
        return true;
    }
    // cannot spy if everyone is sleeping or everyone is awake
    return false;

    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if (prisonerIsAwake && !archerIsAwake)
        {
            return true;
        }
        else 
            return false;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if(petDogIsPresent)
        {
            if(knightIsAwake && !archerIsAwake)
            {
                return true;
            }

            if(!knightIsAwake && !archerIsAwake)
            {
                return true;
            }
        }
        else
        {
             if(prisonerIsAwake && !knightIsAwake && !archerIsAwake)
             {
                 return true;
             }
        }

        return false;
    }
}
