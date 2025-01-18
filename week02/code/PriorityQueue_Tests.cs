using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: enqueue five items with priorities and verify they dequeue in the correct priority order
    // Expected Result: value4, value5, value3, value2, value1
    // Defect(s) Found: the items werent removed properly and the highestPriorityIndex wasnt tracked correctly.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        var value1 = new PriorityItem("Value 1", 1);
        var value2 = new PriorityItem("Value 2", 2);
        var value3 = new PriorityItem("Value 3", 3);
        var value4 = new PriorityItem("Value 4", 4);
        var value5 = new PriorityItem("Value 5", 4);

        PriorityItem[] expectedResult = new[] { value4, value5, value3, value2, value1 };


        priorityQueue.Enqueue("Value 1", 1);
        priorityQueue.Enqueue("Value 2", 2);
        priorityQueue.Enqueue("Value 3", 3);
        priorityQueue.Enqueue("Value 4", 4);
        priorityQueue.Enqueue("Value 5", 4);

        int i = 0;
        while (priorityQueue.Length > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var value = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, value);
            i++;
        }
    }

    [TestMethod]
    // Scenario: test an empty queue, to see if the error is being displayed correctly.
    // Expected Result: the error "throw new InvalidOperationException("The queue is empty.");" should be thrown
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        //this was just to check if the test works as intended
        //priorityQueue.Enqueue("Value 1", 1);
        
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Expected an InvalidOperationException to be thrown.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message);
        }
    }

    // Add more test cases as needed below.
}