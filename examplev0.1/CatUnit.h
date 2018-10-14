#include <assert.h>
#include <stdio.h>



#define TEST_ASSERT(condition, func_name) if(condition == 1){fclose(fputs("Test ok", fopen(func_name  ".ok", "w")));} else{fclose(fputs("Test error", fopen(func_name  ".er", "w")));}
#define TEST_ASSERT_0NE_MESSAGE(condition, messages, func_name) if(condition == 1){fclose(fputs(messages, fopen(func_name  ".ok", "w")));} else{fclose(fputs(messages, fopen(func_name  ".er", "w")));}
#define TEST_ASSERT_BOOL_EQUAL(condition1, condition2, func_name) if(condition1 == condition2){fclose(fputs("Test ok", fopen(func_name  ".ok", "w")));} else{fclose(fputs("Test error", fopen(func_name  ".er", "w")));}
#define TEST_ASSERT_NUM_GREATER(NUM, threshold, func_name) if(NUM <= threshold) {fclose(fputs("Test ok", fopen(func_name  ".ok", "w")));} else{fclose(fputs("Test error", fopen(func_name  ".er", "w")));}