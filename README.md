# FairCastleOwnershipVote

## Description

A mod for Mount & Blade II: Bannerlord which makes it twice as likely for the player clan to be one of the candidates in the vote on new owner of a successfully besieged settlement.

The original formula for calculating the merit of putting a clan on the ballot is roughly as follows. This mod simply doubles the result of that formula for the player.

Sum of the following values:

* 50 × Clan tier
* Sum of total party strength of all nobles in the hero's clan
* 50 × Number of commanders in siege
* 25 × Number of nobles in clan
* 25 (if clan has no fortifications)
* 50 (if it's the player clan)
* 25 (if it's the leader of the siege)
* 50 (if it's the kingdom leader)

Divided by:

20000 × (The sum of all the clan's fortifications value for kingdom + The value of the captured settlement for kingdom) × (A coefficient which is smaller if the clan has nearby settlements)

## Installing the module

Download the latest release. Extract the zip file to the Modules directory of your Mount & Blade directory. You should have a folder named FairCastleOwnershipVote. Or, if you're building the code, just following the Building the solution instructions and it will copy the necessary files to your Modules directory.

## Building the solution

Update the MOUNT_AND_BLADE_DIR property in FairCastleOwnershipVote.props to the root of your Bannerlord directory. Make sure to include a trailing backslash.

## License

MIT