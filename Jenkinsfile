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
			     bat "dotnet test ElibraryManagement/DemoTest/DemoTest.csproj"
		    }
		    
		     stage("Solution") {
		    steps{
			     bat "dotnet test ElibraryManagement/ElibraryManagement.sln"
		    }
	}   }
}
	
