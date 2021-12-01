pipeline {
    agent any
	triggers {
		pollSCM("* * * * *")
	}
	stages{
	    stage("Run Tests") {
		    steps{
			     sh "dotnet test ElibraryManagement/DemoTest/DemoTest.csproj"
		    }
	}   }
}
	
