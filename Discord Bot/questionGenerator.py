import random

def get_random_question():
    with open('questions.txt', 'r') as file:
        questions = file.readlines()
    return random.choice(questions)

    print(get_random_question())

def have_fun():
    with open('kufur.txt', 'r') as file:
        questions = file.readlines()
    return random.choice(questions)

    print(get_random_question())

have_fun()
get_random_question()
