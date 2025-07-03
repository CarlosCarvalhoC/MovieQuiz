using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Media;

namespace MovieQuiz
{
    public partial class Form1 : Form
    {
        // --- Fields ---

        // The current movie being guessed
        private string currentMovie;
        // Tracks which image in the sequence to display
        private int currentImageIndex; 
        private int score = 0; // Tracks the player's score
        private int totalMovies = 0; // Tracks total movies shown
        private Random random = new Random(); // Random number generator for selecting movies
        private List<PictureBox> pictureBoxes; // List of PictureBox controls to display images
        private HashSet<string> guessedMovies = new HashSet<string>(); // Tracks all movies that have been shown
        private int moviesToShow; // Total number of unique movies available to show
        private bool isGameOver = false; // Flag to indicate if the game is over
        private string selectedCategory; // Store the selected category
        private int totalTime = 60; // Total time for the category in seconds
        private int elapsedTime = 0; // Time elapsed since the game started
        // Sound players for correct and wrong answers
        private SoundPlayer correctSoundPlayer;
        private SoundPlayer wrongSoundPlayer;

        // --- Constructor ---
        public Form1(string category)
        {
            InitializeComponent();
            selectedCategory = category; // Store the passed category

            pictureBoxes = new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };
            moviesToShow = MovieLibrary.Categories[selectedCategory].Count;

            // Initialize the SoundPlayer instances with the respective sound files
            correctSoundPlayer = new SoundPlayer(Properties.Resources.correct);
            wrongSoundPlayer = new SoundPlayer(Properties.Resources.wrong);

            progressBar.Maximum = totalTime; // Matches the total game time
            progressBar.Value = 0;

            ShowNextMovie(); // Start the game by showing the first movie
            timer.Start(); // Start the timer
        }

        // --- Core Game Methods ---

        /// <summary>
        /// Prepares and displays the next movie to be guessed.
        /// </summary>
        private void ShowNextMovie()
        {
            if (isGameOver)
                return;

            if (guessedMovies.Count >= moviesToShow)
            {
                EndGame();
                return;
            }

            ClearImages();
            currentImageIndex = 0;

            do
            {
                currentMovie = GetRandomMovie();
            } while (guessedMovies.Contains(currentMovie));

            guessedMovies.Add(currentMovie);

            List<Image> movieImages = MovieLibrary.Categories[selectedCategory][currentMovie];
            DisplayCurrentImage(movieImages);

            SetButtonOptions(currentMovie);
            totalMovies++;
            imageTimer.Start();
        }

        /// <summary>
        /// Ends the game and displays the final score.
        /// </summary>
        private void EndGame()
        {
            imageTimer.Stop();
            timer.Stop();
            isGameOver = true;

            MessageBox.Show($"Game Over! You guessed {score} movies correctly out of {totalMovies}.",
                            "Game Over",
                            MessageBoxButtons.OK);

            this.Close(); // Close the quiz form and return to the title screen
        }

        /// <summary>
        /// Retrieves a random movie title from the MovieLibrary.
        /// </summary>
        private string GetRandomMovie()
        {
            List<string> moviesInCategory = MovieLibrary.Categories[selectedCategory].Keys.ToList();
            return moviesInCategory[random.Next(moviesInCategory.Count)];
        }

        // --- Event Handlers ---

        /// <summary>
        /// Handles the button click events for guessing the movie.
        /// </summary>
        private void AnyButtonClicked(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (clickedButton.Text == currentMovie)
            {
                score++;
                correctSoundPlayer.Play(); // Play the sound effect for a correct answer
            }
            else
            {
                wrongSoundPlayer.Play(); // Play the sound effect for a wrong answer
            }

            if (totalMovies >= moviesToShow)
                EndGame();
            else
                ShowNextMovie();
        }

        /// <summary>
        /// Handles the image timer tick to show the next image.
        /// </summary>
        private void ImageTimer_Tick(object sender, EventArgs e)
        {
            currentImageIndex++;
            string currentCategory = MovieLibrary.Categories.FirstOrDefault(categories => categories.Value.ContainsKey(currentMovie)).Key;
            List<Image> movieImages = MovieLibrary.Categories[currentCategory][currentMovie];

            if (currentImageIndex < movieImages.Count)
                DisplayCurrentImage(movieImages);
            else
                imageTimer.Stop();
        }

        /// <summary>
        /// Handles the main timer tick for updating elapsed time and the progress bar.
        /// </summary>
        private void timer_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            progressBar.Value = elapsedTime;

            if (elapsedTime >= totalTime)
            {
                timer.Stop();
                EndGame();
            }
        }

        // --- Helper Methods ---

        /// <summary>
        /// Clears all images from the PictureBox controls.
        /// </summary>
        private void ClearImages()
        {
            foreach (var pictureBox in pictureBoxes)
            {
                pictureBox.Image = null;
            }
        }

        /// <summary>
        /// Displays the current image for the movie based on the index.
        /// </summary>
            private void DisplayCurrentImage(List<Image> movieImages)
            {
                if (currentImageIndex < movieImages.Count)
                {
                    pictureBoxes[currentImageIndex].Image = movieImages[currentImageIndex];
                }
            }

        /// <summary>
        /// Sets the button text options for the current movie.
        /// </summary>
        private void SetButtonOptions(string correctMovie)
        {
            List<Button> buttons = new List<Button> { button1, button2, button3, button4 };
            HashSet<string> usedMovies = new HashSet<string> { correctMovie };


            foreach (var button in buttons)
            {
                string movie;
                do
                {
                    movie = GetRandomMovie();
                } while (usedMovies.Contains(movie));

                button.Text = movie;
                usedMovies.Add(movie);
            }

            buttons[random.Next(buttons.Count)].Text = correctMovie;
        }

    }
}
