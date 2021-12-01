pipeline {
    agent any
	triggers {
		pollSCM("* * * * *")
	}
	stages{
		stage("Check") {
			steps{
				echo "yeee"
			}
		}
		
	    stage("Run Tests") {
		    steps{
			     sh "dotnet test ElibraryManagement/DemoTest/UnitTest1.cs "
		    }
	}   }
}
	
