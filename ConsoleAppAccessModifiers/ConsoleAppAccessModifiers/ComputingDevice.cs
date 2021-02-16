using System;

class ComputingDevice
{
    // only child classes access here
    protected string caseColor = "black";
    //accessible anywhere
    public virtual void Read()
    {
        Console.WriteLine("Reading key strokes.... ");
    }
}
