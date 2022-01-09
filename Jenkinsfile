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
		 stage("Solution") {
		    steps{
			     bat "dotnet build ElibraryManagement/WebApplication3/adminauthormanagement.aspx"
		    }
	    }
		
	    stage("Run Tests") {
		    steps{
			     bat "dotnet test ElibraryManagement/DemoTest/DemoTest.csproj"
		    }
	    }
		
	    
		    
		    
       }           
}
	
