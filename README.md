# Quiz Application

This application allows users to take quizzes on various topics. It includes a list of available quizzes, and users can choose a quiz to start answering questions.

## How to Run the Application
1. Clone the repository:
   
    git clone https://github.com/christauwicyeza/quiz-game-windows.git

2. Open the solution in Visual Studio:
   - Open Visual Studio.
   - Click on "File" > "Open" > "Project/Solution."
   - Navigate to the cloned repository and open the solution file (.sln).

3. Build and run:
   - Build the solution by clicking on "Build" > "Build Solution."
   - Run the application by clicking on the "Start" button (green triangle) or pressing F5.

## How to Use the Application

### Available Quizzes: Quiz Selection
1. Launch the application to see the available quizzes.
2. Click on a quiz to start answering questions.

### Quiz Form: Answering Questions
1. The Quiz Form displays questions for the selected quiz.
2. Answer each question by clicking the corresponding button.
3. Immediate feedback is given for each answer.
4. The quiz progresses to the next question automatically.

After completing the quiz, a summary is displayed, showing the number of correct answers, the percentage, and the weighted score.

## Additional Features

### Retaking the Quiz:
After completing a quiz, users can choose to retake it or end the quiz.

### Exception Handling:
The application uses exception handling to provide meaningful error messages to the user.

### Quiz Models
The application uses Quiz and Question models to organize quiz data.

### Testing Strategy
The application has been tested using unit tests for individual methods and integration tests for interactions between different components.
