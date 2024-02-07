pipeline {
    agent any
    environment{
        dotnet= '/usr/local/share/dotnet/dotnet'
    }
    stages {
        stage('Checkout') {
            steps {
                // Checkout source code from repository
                git credentialsId: 'github_access_token', url: 'https://github.com/upretymadan45/modular-monolith.git'
            }
        }
        
        stage('Build') {
            steps {
               sh 'dotnet build'
            }
        }
    }
}
