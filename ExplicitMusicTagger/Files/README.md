## READ ME

Please keep in mind that I cannot promise this application will catch all bad language. It is a tool to help you mark and minimize bad language listening. Some of the work will be on you. Please read more.

### Instructions

Drag .m4a files or folders containing .m4a files to the "Files to Process" window. Preferrably these files should have lyrics added to them. "MediaHuman Lyrics Finder" is an application I've used.

#### The Confirmation Process

WARNING: You are going to still see some language!

During this process, the application will look through the lyrics to find anything on the "Base Explict Word List." If it finds something, it will prompt you to confirm if what it found was actually explicit or not. If a song is deemed explicit, the "Comments" metadata tag will have the string `[Explicit]` added.

Why are you confirming? Because artists are creative and make up new compound words including ones with bad language. But don't worry! You will be asked less and less as files are processed.

#### Word Lists

There are three word lists. "Base Explict Words," "Explicit Words," and "Exceptions." You can edit any of these lists, but the main list to consider is "Base Explicit Words."

The "Base Explicit Words" list contains basic things I came across with my own music. This is a simplistic list of words, partial words, or special characters that has does not have the different variations of words; such as words with "-ly" or "-er" added. The confirmation process should catch these variations for you to check. The special characters, such as "*" (asterisk), are on the list because the lyrics you add can come from different sources and have some auto-censoring going on in the lyrics. The music would still contain such words. The point of these words, partials, and special characters is to make sure to catch the most cases possible.

The "Explicit Words" list are the confirmed bad words. As words are added to this list, the confirmation process will skip over exact matches and mark explicit automatically. If you make a mistake adding a non-explicit word, you can edit the list in the menu.

The "Exceptions" list are words that you confirmed not explicit. I know that, for example, "assemble" is not a bad word. That's why there is also a ton of words already on the "Exception" list based on my own confirmations. If you make a mistake adding an explicit word, you can edit the list in the menu.

#### What To Do After Songs Are Tagged

I use iTunes personally. So, unfortunately, I can't offer suggestions on other music organization/player apps. However, on iTunes, you can add filtering on a Smart Playlist. The basic filter would be:

`Comments` &nbsp;&nbsp;&nbsp;&nbsp; `does not contain` &nbsp;&nbsp;&nbsp;&nbsp; `[Explicit]`

Again, the search text in the filter should be "[Explicit]" (Square-Bracket Explicit Close-Square-Bracket).

Problem? I'm assuming you might have the same one I had. The Smart Playlist may not notice the change on the Comments tag. So unfortunately, you may have to force iTunes to "update" the knowledge of a comment by looking at the song's info in iTunes. I typically start with right-clicking the first song in an album and choosing "Song Info." Then using the arrow buttons, you can move through the songs and see the comments tag populate.

### Questions You May Have

#### Why only .m4a files?

Apologies up front. I only considered iTunes because I've been a user of it for quite some time. This was mainly a personal use project to allow me to listen to my music around my kids with less worry about the language. I found it best for me to rip my music and keep it in one file format. I also found it easier to work with the metadata on .m4a files. So, yes, you will have to convert your music to .m4a for this to work.


#### Will this work on songs I've purchased from Apple or from the Apple Music subscription?

Actually, yes. But let's talk about the difference between songs you've ripped youself (which I just refer to as "your music" or "your own music") and songs from Apple purchases or the Apple Music subscription (which I will just refer to as "Apple music"). Your music, once converted, will be .m4a files while Apple music, once downloaded, will be .m4p files. I did say downloaded, btw. Apple music must be downloaded to alter. You'll have to find Apple music in a separate folder called "Apple Music."

Most Apple music already has lyrics that you can view and has an included "E" symbol to indicate a song's explicit status. However, Apple has still not provided a way to create a Smart Playlist with filtering on that "E" symbol. However, Explicit Music Tagger can see this "E" tag from Apple and update the comments tag. So the same course of action for your own music will have to be taken to filter on the "comments" tag.