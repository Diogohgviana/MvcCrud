pipeline {
    agent any

    stages {
        stage('Restore') {
            steps {
                echo 'Restoring...'
                bat "dotnet --version"
            }
        }
        stage('Build') {
            steps {
                echo 'Building..'
                bat "dotnet --version"
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
            }
        }
    }
}
