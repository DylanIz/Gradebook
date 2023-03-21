using System;
using Xunit;



namespace GradeBook.Tests;

public class BookTests
{
    [Fact]
    public void BookCalculatesAnAverageGrade()
    {
        // arange
        var book = new InMemoryBook("");
        book.AddGrade(99.1);
        book.AddGrade(22.3);
        book.AddGrade(32.9);


        // act
        var result = book.GetStatistics();


        // assert
        Assert.Equal(51.4, result.Average, 1);
        Assert.Equal(99.1, result.High, 1);
        Assert.Equal(22.3, result.Low, 1);
        Assert.Equal('F',result.Letter);




        
    }
}