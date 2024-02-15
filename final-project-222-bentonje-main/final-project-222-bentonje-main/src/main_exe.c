#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <math.h>

#define N 10
#define M 6

int roll_dice() {
    int sum=0;
    for(int i = 0; i < N; i++) {
        int roll = rand() % M + 1;
        sum += roll;
    }
    return sum;
}

int main() {
    int num_rolls = 10000;
    int num_samples = N*M+1;
    int sample_sum = 0;
    double sample_var_sum = 0.0;
    double sample_mean = 0.0;
    double sample_variance = 0.0;
    double sample_stddev = 0.0;
    int j;
    int sum;

    srand(time(NULL));

    int *hist = malloc(num_samples * sizeof(int));

    for(j = 0; j < num_rolls; j++) {
        sum = roll_dice();
        hist[sum] += 1;
    }

    for (j=0; j<num_samples; j++) {
        sample_sum += hist[j]*j;
    }
    sample_mean = (float)(sample_sum)/num_rolls;
    printf("Mean = %f\n", sample_mean);

    for (j=0; j<num_samples; j++) {
        printf("%d, %d\n", j, hist[j]);
        sample_var_sum += hist[j]*(pow((float)j-sample_mean,2.0));
    }
    sample_variance = (float)(sample_var_sum)/num_rolls;
    printf("Variance = %f\n", sample_variance);

    sample_stddev = pow(sample_variance,0.5);
    printf("Std Deviation = %f\n", sample_stddev);

    /*
    printf("Number of rolls: %d\n", num_rolls);

    //plot a histogram
    int num_bins = 10;
    double bin_width = (double) (sample_means[num_samples - 1] - sample_means[0]) / num_bins;
    double *bins = (double*) malloc(num_bins * sizeof(double));

    for(i = 0; i < num_bins; i++) {
        bins[i] = sample_means[0] + bin_width;
    }

    int *histogram = (int*) malloc(num_bins * sizeof(int));
    for(i = 0; i < num_bins; i++) {
        for(j = 0; j < num_samples; j++) {
            if(sample_means[j] >= bins[i] && sample_means[j] < bins[i + 1]) {
                histogram[i]++;
            }
        }
    }

    for(i = 0; i < num_bins; i++) {
        printf("%f - %f: %d\n", bins[i], bins[i + 1], histogram[i]);
    }
    */
    return 0;
}
