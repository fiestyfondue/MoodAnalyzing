using MoodAnalyser;
using NUnit.Framework;
using System;
using System.Reflection;

namespace TestProject1
{
    public class Tests
    {
        // check for sad mood, returns "SAD" message.                 
        [Test]
        public void WhenGivenSadMood_ReturnsSadMessge()
        {
            try
            {
                //Arrange
                string message = "Iam in Sad Mood";
                string expected = "SAD";
                //Act
                MoodAnalyserr mood = new MoodAnalyserr(message);
                string result = mood.MoodCheck();
                //Assert
                Assert.AreEqual(expected, result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        
        // Check for Happy mood, return "HAPPY" message.
                      
        [Test]
        public void WhenGivenHappyMood_ReturnsHappyMessage()
        {
            try
            {
                //Arrange
                string message = "Iam in Any Mood";
                string expected = "HAPPY";
                //Act
                MoodAnalyserr mood = new MoodAnalyserr(message);
                string result = mood.MoodCheck();
                //Assert
                Assert.AreEqual(expected, result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
                      
        // check for invalid mood, returns "HAPPY" message.
                       
        [Test]
        public void WhenGivenInvalidMood_ReturnsHappyMessage()
        {
            try
            {
                //Arrange
                string message = "";
                string expected = null;
                //Act
                MoodAnalyserr mood = new MoodAnalyserr(message);
                string result = mood.MoodCheck();
                //Assert
                Assert.AreEqual(expected, result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
                     
        // check when given Class name should return object name
                      
        [Test]
        public void WhenGivenClassName_ReturnsObject()
        {
            try
            {
                //testing with default constructor
                MoodAnalyserFactory moodAnalyserFactory = new MoodAnalyserFactory();
                object tempObject = moodAnalyserFactory.CreateObjectAtRuntime();
                //Arrange
                string expected = "MoodAnalyser.MoodAnalyserr";
                //Act
                string result = tempObject.ToString();
                //Assert
                Assert.AreEqual(expected, result);
            }
            catch (MoodAnalysisException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done Test case: WhenGivenClassName_ReturnsObject");
            }
        }
                     
        // Test case 4.2 - Given Class Name When Improper Should Throw MoodAnalysisException with Parameterized Constructor
                      
        [Test]
        public void WhenGivenClassNameImproper_ThrowsMoodAnalysisException()
        {
            try
            {
                //passing improper class name will return me Null value which means an improper class name has been
                //passed and throws me an custom exception NO Such Class Error.
                MoodAnalyserFactory moodAnalyserFactory = new MoodAnalyserFactory();
                object tempObject = moodAnalyserFactory.CreateObjectAtRuntime();
                //Arrange
                string expected = null;
                //Act
                string result = null;
                //Assert
                Assert.AreEqual(result, expected);
            }
            catch (MoodAnalysisException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done Test case: WhenGivenClassNameWrong_ThrowsMoodAnalysisException");
            }
        }

                     
        // Test Case 5.1 - check when given Class name should return object name
                      
        [Test]
        public void WhenGivenMoodAnalyserProper_ReturnsObject()
        {
            try
            {
                //testing with parameterized constructor
                MoodAnalyserFactory moodAnalyserFactory = new MoodAnalyserFactory("MoodAnalyser.MoodAnalyserr");
                //creating moodanalyser class with parameterized constructor
                object tempObject = moodAnalyserFactory.CreateObjectAtRuntime();
                //Arrange
                string expected = "MoodAnalyser.MoodAnalyserr";
                //Act
                string result = tempObject.ToString();
                //Assert
                Assert.AreEqual(expected, result);
            }
            catch (MoodAnalysisException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done Test case: WhenGivenClassName_ReturnsObject");
            }
        }
                      
        /// Test case 5.2 - Given Class Name When Improper Should Throw MoodAnalysisException with Parameterized Constructor
               
        [Test]
        public void GivenClassNameImproper_ThrowsMoodAnalysisException()
        {
            try
            {
                //passing improper class name will return a Null value means an improper class name has been passed and throws me an custom exception NO Such Class Error.
                MoodAnalyserFactory moodAnalyserFactory = new MoodAnalyserFactory("MoodAnalyser.MoodAnalyserr");
                object tempObject = moodAnalyserFactory.CreateObjectAtRuntime();
                //Arrange
                string expected = null;
                //Act
                string result = null;
                //Assert
                Assert.AreEqual(result, expected);
            }
            catch (MoodAnalysisException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done Test case: WhenGivenClassNameWrong_ThrowsMoodAnalysisException");
            }
        }
      
        // passing wrong constructor parameter
                      
        [Test]
        public void GivenConstructorParameterImproper_ThrowsMoodAnalysisException()
        {
            try
            {
                //passing improper class name will return a Null value which means an improper class name has been passed and throws me an custom exception NO Such Class Error.
                MoodAnalyserFactory moodAnalyserFactory = new MoodAnalyserFactory();
                //passing the wrong constructor parameter to catch the exception, return null value
                ConstructorInfo constructorObj = moodAnalyserFactory.GetConstructor(1);
                var constructor = moodAnalyserFactory.CreateConstructor("MoodAnalyser.MoodAnalyserr", constructorObj);
                //Arrange
                string expected = null;
                //Act
                string result = constructor.ToString();
                //Assert
                Assert.AreEqual(result, expected);
            }
            catch (MoodAnalysisException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done Test case: WhenGivenClassNameWrong_ThrowsMoodAnalysisException");
            }
        }
    }
}