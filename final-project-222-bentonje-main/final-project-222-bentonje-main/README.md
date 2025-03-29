
================================================================

# 🎲 Monte Carlo Dice Roll Simulation & Statistical Analysis  

## 📌 Overview  
This C program uses the **Monte Carlo method** to simulate rolling **10 six-sided dice (D6) 10,000 times** and analyze the statistical properties of the outcomes.  

Using random sampling, it estimates:  
- **Mean (Expected Value)**  
- **Variance**  
- **Standard Deviation**  

The program helps visualize the probability distribution of rolling multiple dice, making it a great introduction to Monte Carlo simulations in probability and statistics.  

## 🎯 What is the Monte Carlo Method?  
The **Monte Carlo method** is a computational technique that uses repeated **random sampling** to estimate numerical results. In this case, it approximates the probability distribution of dice sums by generating a large number of random outcomes.  

Monte Carlo simulations are widely used in:  
- **Game theory & gambling probabilities**  
- **Risk analysis in finance**  
- **Physics simulations (e.g., particle behavior)**  
- **Machine learning & AI optimization**  

## 📜 How It Works  
1. **Dice Rolling Function (`roll_dice`)**  
   - Rolls `N = 10` six-sided dice (`M = 6`) per trial.  
   - Computes and returns the sum of all dice rolls.  

2. **Simulation (`main`)**  
   - Runs `num_rolls = 10,000` simulations.  
   - Stores the frequency of each sum in an array (`hist`).  
   - Computes **mean**, **variance**, and **standard deviation**.  
   - Outputs statistical results to the console.  


