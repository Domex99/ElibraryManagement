pipeline {
    agent any
    stage("Build") {
           stage("Test API") {
            steps {
		  sh "dotnet test ElibraryManagement/UnitTestElibraryManagement/UnitTestElibraryManagement.csproj"
            }
}
