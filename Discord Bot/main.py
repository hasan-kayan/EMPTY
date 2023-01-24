import discord
import questionGenerator as question
import QRCode as qr 


client = discord.Client(intents=discord.Intents.all())

@client.event
async def on_ready():
    print('We have logged in as {0.user}'.format(client))

@client.event
async def on_message(message):
    if message.author == client.user:  
     return

    if message.content.startswith('$hello'):

      await message.channel.send('Hello!')
    if message.content.startswith('$question'):
      await message.channel.send(question.get_random_question())
    if message.content.startswith('$qr'):
      await message.channel.send("Please enter the url you want to embedded : ")
      url = input(message.content)

      await message.channel.send(qr.urlToQR(url))

client.run('Enter your TOKEN between the quotes')


