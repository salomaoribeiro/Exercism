using Xunit;

public class BobTests
{
    [Fact]
    public void Stating_something()
    {
        Assert.Equal("Whatever.", Bob.Response("Tom-ay-to, tom-aaaah-to."));
    }

    [Fact(Skip = "")]
    public void Shouting()
    {
        Assert.Equal("Whoa, chill out!", Bob.Response("WATCH OUT!"));
    }

    [Fact(Skip = "")]
    public void Shouting_gibberish()
    {
        Assert.Equal("Whoa, chill out!", Bob.Response("FCECDFCAAB"));
    }

    [Fact(Skip = "")]
    public void Asking_a_question()
    {
        Assert.Equal("Sure.", Bob.Response("Does this cryogenic chamber make me look fat?"));
    }

    [Fact(Skip = "")]
    public void Asking_a_numeric_question()
    {
        Assert.Equal("Sure.", Bob.Response("You are, what, like 15?"));
    }

    [Fact(Skip = "")]
    public void Asking_gibberish()
    {
        Assert.Equal("Sure.", Bob.Response("fffbbcbeab?"));
    }

    [Fact(Skip = "")]
    public void Talking_forcefully()
    {
        Assert.Equal("Whatever.", Bob.Response("Hi there!"));
    }

    [Fact(Skip = "")]
    public void Using_acronyms_in_regular_speech()
    {
        Assert.Equal("Whatever.", Bob.Response("It's OK if you don't want to go work for NASA."));
    }

    [Fact(Skip = "")]
    public void Forceful_question()
    {
        Assert.Equal("Calm down, I know what I'm doing!", Bob.Response("WHAT'S GOING ON?"));
    }

    [Fact(Skip = "")]
    public void Shouting_numbers()
    {
        Assert.Equal("Whoa, chill out!", Bob.Response("1, 2, 3 GO!"));
    }

    [Fact(Skip = "")]
    public void No_letters()
    {
        Assert.Equal("Whatever.", Bob.Response("1, 2, 3"));
    }

    [Fact(Skip = "")]
    public void Question_with_no_letters()
    {
        Assert.Equal("Sure.", Bob.Response("4?"));
    }

    [Fact(Skip = "")]
    public void Shouting_with_special_characters()
    {
        Assert.Equal("Whoa, chill out!", Bob.Response("ZOMG THE %^*@#$(*^ ZOMBIES ARE COMING!!11!!1!"));
    }

    [Fact(Skip = "")]
    public void Shouting_with_no_exclamation_mark()
    {
        Assert.Equal("Whoa, chill out!", Bob.Response("I HATE THE DENTIST"));
    }

    [Fact(Skip = "")]
    public void Statement_containing_question_mark()
    {
        Assert.Equal("Whatever.", Bob.Response("Ending with ? means a question."));
    }

    [Fact(Skip = "")]
    public void Non_letters_with_question()
    {
        Assert.Equal("Sure.", Bob.Response(":) ?"));
    }

    [Fact(Skip = "")]
    public void Prattling_on()
    {
        Assert.Equal("Sure.", Bob.Response("Wait! Hang on. Are you going to be OK?"));
    }

    [Fact(Skip = "")]
    public void Silence()
    {
        Assert.Equal("Fine. Be that way!", Bob.Response(""));
    }

    [Fact(Skip = "")]
    public void Prolonged_silence()
    {
        Assert.Equal("Fine. Be that way!", Bob.Response("          "));
    }

    [Fact(Skip = "")]
    public void Alternate_silence()
    {
        Assert.Equal("Fine. Be that way!", Bob.Response("\t\t\t\t\t\t\t\t\t\t"));
    }

    [Fact(Skip = "")]
    public void Multiple_line_question()
    {
        Assert.Equal("Whatever.", Bob.Response("\nDoes this cryogenic chamber make me look fat?\nNo."));
    }

    [Fact(Skip = "")]
    public void Starting_with_whitespace()
    {
        Assert.Equal("Whatever.", Bob.Response("         hmmmmmmm..."));
    }

    [Fact(Skip = "")]
    public void Ending_with_whitespace()
    {
        Assert.Equal("Sure.", Bob.Response("Okay if like my  spacebar  quite a bit?   "));
    }

    [Fact(Skip = "")]
    public void Other_whitespace()
    {
        Assert.Equal("Fine. Be that way!", Bob.Response("\n\r \t"));
    }

    [Fact(Skip = "")]
    public void Non_question_ending_with_whitespace()
    {
        Assert.Equal("Whatever.", Bob.Response("This is a statement ending with whitespace      "));
    }
}
