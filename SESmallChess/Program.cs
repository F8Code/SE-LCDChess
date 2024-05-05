//                                                                                              SETTINGS
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//You can change below settings and recompile the script at any time without losing your data!

//### Board display settings! ###
//Increasing this number by X makes the board rotate X times clockwise
int boardRotation = 0;

//If true the board will rotate 180 degrees after each move
bool boardRotates = false;

//Only affects in-game and analysis mode. 
//You can still use left-middle-right bottom options via running the script vith arguments "option1", "option2", "option3"
bool fullScreen = false;

//Time before the selected piece becomes 'deselected'
int selectionLife = 5;

//### Some animation settings ###
//Animation speeds! Advised numbers: 0 to 5
//0 turns the animations off, after that the larger the number the slower the animation will be
int animationSpeed = 1;
int gameLoadSpeed = 1;

//true - knights will move in L shape, false - knights will cut the turn
bool knightsFullMove = true;

//### Sound settings ###
//In the "SoundSettings" section below only change the "SoundName = " or the "Volume = " part, or change any true to false and vice versa
//The list of available SoundName's can be found in the programmable block "Custom Data" section
//The Volume number should range from 0 to 1, if you use a number between 0 and 1 you have to add an F, for example: 0.45F
bool isSound = true;
SoundSettings moveSound = new SoundSettings { SoundName = "MusComp_07", Volume = 1 };
SoundSettings arrivalSound = new SoundSettings { SoundName = "MusComp_02", Volume = 1 };
SoundSettings checkSound = new SoundSettings { SoundName = "SoundBlockAlert2", Volume = 1 };
SoundSettings promotionSound = new SoundSettings { SoundName = "MusAlien_02", Volume = 1 };
SoundSettings captureSound = new SoundSettings { SoundName = "MusBuild_04", Volume = 0.4F };

bool isMusic = true;
SoundSettings gameEndMusic = new SoundSettings { SoundName = "MusFun", Volume = 0.05F };

//### Message display time settings ###
//Advised numbers: 1 to 10
int errorMessageTime = 2;
int endOfGameMessageTime = 4;

//### The minimum ammount of turns required to save the game (useful for servers) ###
int minTurnToSave = 5;

//                                                                                    BLOCKS AND GROUPS
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//

//Names of your components and groups for the program to use
string chessPanelLcd = "LCD_ChessPanel"; //<- REQUIRED ON YOUR GRID!
string whiteTimerBlock = "TB_White";
string blackTimerBlock = "TB_Black";
string soundBlocksGroup = "GameSounds";

//                                                                                             GRAPHICS
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//

string beforeGameOptions = "        NEWG       MENU       ANALYS     ";
string inGameOptions = "      RESIGN     DRAW     TBACK     ";
string analysisOptions = "      NEXTM         PREVM         EXIT      ";

char savedWhiteColor = '';
char savedBlackColor = '';
char savedLightSquareColor = '';
char savedSelectedLightSquareColor = '';

char newWhiteColor = '';
char newBlackColor = '';
char newLightSquareColor = '';
char newDarkSquareColor = '';
char newSelectedLightSquareColor = '';
char newSelectedDarkSquareColor = '';

char leftButtonColor = '';
char middleButtonColor = '';
char rightButtonColor = '';

List<string> letterStrings = new List<string>()
{
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n"
};

List<string> imageStrings = new List<string>()
{
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
    "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n"
};

Dictionary<string, int> NameToIndex = new Dictionary<string, int>
{
    { "wKing_wSquare", 0 },
    { "possible_wKing_wSquare", 1 },
    { "wQueen_wSquare", 2 },
    { "possible_wQueen_wSquare", 3 },
    { "wBishop_wSquare", 4 },
    { "possible_wBishop_wSquare", 5 },
    { "wKnight_wSquare", 6 },
    { "possible_wKnight_wSquare", 7 },
    { "wRook_wSquare", 8 },
    { "possible_wRook_wSquare", 9 },
    { "wPawn_wSquare", 10 },
    { "possible_wPawn_wSquare", 11 },
    { "wSquare", 12 },
    { "possible_wSquare", 13 },
    { "special_wSquare", 14 }
};

//                                                                                              PROGRAM
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//|#| in game blocks and group placeholders |#|
IMyTextPanel panel;
IMyTimerBlock TB_White, TB_Black;
List<IMySoundBlock> soundBlocks = new List<IMySoundBlock>();

//|#| struct used for setting different event sounds and their loudness |#|
struct SoundSettings
{
    public string SoundName;
    public float Volume;
}

//|#| enum used to determine the ChessFigure type |#|
public enum ChessPiece
{
    Pawn,
    Rook,
    Knight,
    Bishop,
    Queen,
    King
}

//|#| class from which an 8x8 chessBoard array is created |#|
public class ChessFigure
{
    public ChessPiece type { get; set; }
    public bool color { get; }
    public int hasMoved { get; set; }

    public ChessFigure(ChessPiece type, bool color)
    {
        this.type = type;
        this.color = color;
        hasMoved = -1;
    }
    public ChessFigure(ChessFigure copy)
    {
        type = copy.type;
        color = copy.color;
        hasMoved = copy.hasMoved;
    }
}
ChessFigure[,] chessBoard = new ChessFigure[8, 8];
bool[,] possibleSquares = new bool[8, 8];

//|#| structure for holding information about a chess move |#|
public struct MoveInfo
{
    public bool isPromotion { get; set; }
    public bool isLCastling { get; set; }
    public bool isSCastling { get; set; }
    public bool isCheckmate { get; set; }
    public bool isCheck { get; set; }
    public bool isCapture { get; set; }
    public bool isDraw { get; set; }
    public bool isEnPassant { get; set; }
    public ChessPiece pieceType { get; set; }
    public ChessPiece promotedTo { get; set; }
    public ChessFigure capturedPiece { get; set; }
    public int sourceX { get; set; }
    public int sourceY { get; set; }
    public int targetX { get; set; }
    public int targetY { get; set; }
}
MoveInfo moveInfo = new MoveInfo();

//|#| variables and real time use structs |#|
int turnNumber = -1;

int gameState = 1;

int menuChoice = 0;

bool whiteTurn = true;

bool promotionFlag = false, animationFlag = false, enterNameFlag = false, loadGameFlag = false, additionalChoiceFlag = false;

//var used to count the ammount of times the program has entered DrawAnimation()
ChessFigure tempChessPiece;
int animationCounter = 0;

//draws: 0 - none, 1 - stalemate, 2 - fiftyMoves, 3 - threefold, 4 - insufficient material, 5 - agreement
//loses: 0 - none, 1 - checkmate, 2 - surrender, 3 - flag
int drawType = 0, wLossType = 0, bLossType = 0;

ChessPiece promotionPiece = ChessPiece.Queen;

//decision vars, used to determine the players move they want to make (first and second position)
int fPosX = -1, fPosY = -1, sPosX = -1, sPosY = -1;

int[] wKingPos = { 4, 0 }, bKingPos = { 4, 7 }, tempChessPiecePos = { -1, -1 };

int[] selectedPiece = { -1, -1 }, selectedSquare = { -1, -1 };
int savedDir = 0;

//used to check for threefold repetition
List<string> positionKeys = new List<string>();

//used for checking the fiftyMove rule
int fiftyMoveRuleCounter = 0;

//used to determine the turn in which the analysis got modified
int divergenceTurn = -1;

//Array used for auto restoring panels to default states, the values decide how long before the restoration occurs
//0,1 - w,b rotation panels, 2 - w,b increment/time panels, 3 - w,b info panels 
int LCDPanelTime;
int currSelectionTime;

//Structures for player requests - number value usually states the turn the request took place
//0 - game too short to save ; 1 - game already saved ; 2 - this name is already used ; 3 - game lost/drawn
bool[] messageFlags = new bool[4];

int selectedOption = -1;

//|#| structures for saving and loading chess games |#|
List<string> chessNotation = new List<string>();
List<MoveInfo> chessMoves = new List<MoveInfo>();
List<List<string>> chessNotationsList = new List<List<string>>();
List<List<MoveInfo>> chessMovesList = new List<List<MoveInfo>>();
List<string> chessGamesNameList = new List<string>();

public Program()
{
    panel = GridTerminalSystem.GetBlockWithName(chessPanelLcd) as IMyTextPanel;

    panel.Font = "Monospace";
    panel.ContentType = ContentType.TEXT_AND_IMAGE;
    panel.FontSize = fullScreen ? 0.124F : 0.108F;
    panel.TextPadding = 0F;

    TB_White = GridTerminalSystem.GetBlockWithName(whiteTimerBlock) as IMyTimerBlock;
    TB_Black = GridTerminalSystem.GetBlockWithName(blackTimerBlock) as IMyTimerBlock;

    IMyBlockGroup soundGroup = GridTerminalSystem.GetBlockGroupWithName(soundBlocksGroup);
    if (soundGroup != null)
        soundGroup.GetBlocksOfType(soundBlocks);

    Chess_InitializeGame();
    
    string[] storedData = Storage.Split(';');

    if (storedData.Length > 0)
    {
        if (storedData.Length > 0 && storedData[0].Length > 0)
        {
            string[] storedVars = storedData[0].Split(',');
            gameState = int.Parse(storedVars[0]);
            menuChoice = int.Parse(storedVars[1]);
            divergenceTurn = int.Parse(storedVars[2]);
            additionalChoiceFlag = bool.Parse(storedVars[3]);
            enterNameFlag = bool.Parse(storedVars[4]);
        }
        if (storedData.Length > 3 && storedData[3].Length > 0)
        {
            string[] storedChessNotationsList = storedData[3].Split('/');
            foreach (string notationList in storedChessNotationsList)
            {
                string[] storedInnerChessNotation = notationList.Split(',');
                foreach (string notation in storedInnerChessNotation)
                    chessNotation.Add(notation);
                chessNotationsList.Add(chessNotation.ToList());
                chessNotation.Clear();
            }
        }
        if (storedData.Length > 4 && storedData[4].Length > 0)
        {
            string[] storedChessMovesList = storedData[4].Split('/');
            foreach (string movesList in storedChessMovesList)
            {
                string[] storedInnerChessMoves = movesList.Split('|');
                Program_DeserializeMoveList(storedInnerChessMoves);
                chessMovesList.Add(chessMoves.ToList());
                chessMoves.Clear();
            }
        }
        if (storedData.Length > 1 && storedData[1].Length > 0)
        {
            string[] storedChessNotation = storedData[1].Split(',');
            foreach (string notation in storedChessNotation)
                chessNotation.Add(notation);
        }
        if (storedData.Length > 2 && storedData[2].Length > 0)
        {
            string[] storedChessMoves = storedData[2].Split('|');
            Program_DeserializeMoveList(storedChessMoves);
        }
        if (storedData.Length > 5 && storedData[5].Length > 0)
        {
            string[] storedchessGamesNameList = storedData[5].Split(',');
            foreach (string name in storedchessGamesNameList)
                chessGamesNameList.Add(name);
        }
    }

    if(gameState != 3)
    {
        loadGameFlag = true;
        Runtime.UpdateFrequency |= UpdateFrequency.Update1;
    }
    else
        LCD_DrawScreen();
}

public ChessFigure Program_DeserializeChessFigure(string storedChessFigure)
{
    string[] properties = storedChessFigure.Split('.');

    ChessPiece type = (ChessPiece)int.Parse(properties[0]);
    bool color = bool.Parse(properties[1]);
    int hasMoved = int.Parse(properties[2]);

    return new ChessFigure(type, color)
    {
        hasMoved = hasMoved
    };
}

public void Program_DeserializeMoveList(string[] storedChessMoves)
{
    foreach (string move in storedChessMoves)
    {
        string[] innerList = move.Split(',');
        moveInfo.isPromotion = bool.Parse(innerList[0]);
        moveInfo.isLCastling = bool.Parse(innerList[1]);
        moveInfo.isSCastling = bool.Parse(innerList[2]);
        moveInfo.isCheckmate = bool.Parse(innerList[3]);
        moveInfo.isCheck = bool.Parse(innerList[4]);
        moveInfo.isCapture = bool.Parse(innerList[5]);
        moveInfo.isDraw = bool.Parse(innerList[6]);
        moveInfo.isEnPassant = bool.Parse(innerList[7]);
        moveInfo.pieceType = (ChessPiece)int.Parse(innerList[8]);
        moveInfo.promotedTo = (ChessPiece)int.Parse(innerList[9]);
        moveInfo.capturedPiece = innerList[10] == "null" ? null : Program_DeserializeChessFigure(innerList[10]);
        moveInfo.sourceX = int.Parse(innerList[11]);
        moveInfo.sourceY = int.Parse(innerList[12]);
        moveInfo.targetX = int.Parse(innerList[13]);
        moveInfo.targetY = int.Parse(innerList[14]);
        chessMoves.Add(moveInfo);
    }
}

public void Save()
{
    string storedVars = $"{(messageFlags[3] ? 0 : gameState)},{menuChoice},{divergenceTurn},{additionalChoiceFlag},{enterNameFlag}";

    string storedChessNotation = string.Join(",", chessNotation);

    string storedChessMoves;
    List<string> storedInnerList = new List<string>();
    foreach (MoveInfo info in chessMoves)
    {
        string innerList = $"{info.isPromotion},{info.isLCastling},{info.isSCastling},{info.isCheckmate},{info.isCheck},{info.isCapture},{info.isDraw},{info.isEnPassant},{(int)info.pieceType},{(int)info.promotedTo},{(info.capturedPiece != null ? Save_SerializeChessFigure(info.capturedPiece) : "null")},{info.sourceX},{info.sourceY},{info.targetX},{info.targetY}";
        storedInnerList.Add(innerList);
    }
    storedChessMoves = string.Join("|", storedInnerList);

    string storedChessNotationsList;
    storedInnerList.Clear();
    foreach (List<string> notation in chessNotationsList)
    {
        string innerList = string.Join(",", notation);
        storedInnerList.Add(innerList);
    }
    storedChessNotationsList = string.Join("/", storedInnerList);

    string storedChessMovesList;
    storedInnerList.Clear();
    List<string> storedOuterList = new List<string>();
    foreach (List<MoveInfo> infoList in chessMovesList)
    {
        foreach (MoveInfo info in infoList)
        {
            string innerList = $"{info.isPromotion},{info.isLCastling},{info.isSCastling},{info.isCheckmate},{info.isCheck},{info.isCapture},{info.isDraw},{info.isEnPassant},{(int)info.pieceType},{(int)info.promotedTo},{(info.capturedPiece != null ? Save_SerializeChessFigure(info.capturedPiece) : "null")},{info.sourceX},{info.sourceY},{info.targetX},{info.targetY}";
            storedInnerList.Add(innerList);
        }
        string outerList = string.Join("|", storedInnerList);
        storedOuterList.Add(outerList);
        storedInnerList.Clear();
    }
    storedChessMovesList = string.Join("/", storedOuterList);

    string storedchessGamesNameList = string.Join(",", chessGamesNameList);

    Storage = string.Join(";", storedVars, storedChessNotation, storedChessMoves, storedChessNotationsList, storedChessMovesList, storedchessGamesNameList);
}

public string Save_SerializeChessFigure(ChessFigure chessPiece)
{
    return $"{(int)chessPiece.type}.{chessPiece.color}.{chessPiece.hasMoved}";
}

public void Main(string arg, UpdateType updateSource)
{
    if ((updateSource & UpdateType.Update100) != 0)
    {   
        if(LCDPanelTime > 0)
        {
            LCDPanelTime--;
            if (LCDPanelTime == 0)
            {
                if(currSelectionTime <= 0)
                    Runtime.UpdateFrequency &= ~UpdateFrequency.Update100;
                if (messageFlags[3] && isMusic)
                    Sound_PlayMusic(false);
                for (int i = 0; i < 4; i++)
                    messageFlags[i] = false;
            }
        }
        if(currSelectionTime > 0)
        {
            currSelectionTime--;
            if (currSelectionTime == 0)
            {
                if(LCDPanelTime <= 0)
                    Runtime.UpdateFrequency &= ~UpdateFrequency.Update100;
                for (int i = 0; i < 8; i++)
                    for (int j = 0; j < 8; j++)
                        possibleSquares[i, j] = false;
                if(promotionFlag)
                {
                    moveInfo = default(MoveInfo);
                    promotionFlag = false;
                    promotionPiece = ChessPiece.Queen;
                }
            }
        }
    }
    if (animationFlag && (updateSource & UpdateType.Update1) != 0)
        Chess_DrawAnimation(chessBoard[fPosX, fPosY]);
    else if (!animationFlag && loadGameFlag && (updateSource & UpdateType.Update1) != 0)
    {
        if (turnNumber != chessMoves.Count - 1)
            Chess_LoadMove();
        else
        {
            Runtime.UpdateFrequency &= ~UpdateFrequency.Update1;
            loadGameFlag = false;
        }
    }
    if (enterNameFlag)
    {
        if (updateSource == UpdateType.Terminal && arg.Length > 0)
        {
            if (!chessGamesNameList.Contains(arg))
            {
                chessGamesNameList.Add(arg);
                enterNameFlag = false;
            }
            else
            {
                Runtime.UpdateFrequency |= UpdateFrequency.Update100;
                LCDPanelTime = errorMessageTime;
            }
        }
    }
    else if (!messageFlags[0] && !messageFlags[1] && !messageFlags[2] && !messageFlags[3] && !animationFlag && arg.Length > 0)
    {
        if (arg.Length == 2 && !promotionFlag && drawType == 0 && wLossType == 0 && bLossType == 0)
        {
            sPosX = (int)arg[0] - 65;
            sPosY = (int)arg[1] - 49;
            if (fPosX == -1 || chessBoard[fPosX, fPosY] == null || chessBoard[fPosX, fPosY].color != whiteTurn || (chessBoard[sPosX, sPosY] != null && chessBoard[sPosX, sPosY].color == whiteTurn))
            {
                fPosX = sPosX;
                fPosY = sPosY;
                sPosX = sPosY = -1;
            }
            else
            {
                if (Chess_IsValidMove(fPosX, fPosY, sPosX, sPosY))
                    Chess_PerformMove();
                else if (isSound)
                    Sound_PlayGameSounds(false);
            }
        }
        else
            switch (arg)
            {
                case "green":
                    if (additionalChoiceFlag)
                    {
                        selectedOption = 0;
                        if (gameState == 2)
                            Interface_AnalysisHandler();
                        else
                            Interface_MenuHandler();
                    }
                    else if (!promotionFlag)
                        Chess_FindNextValidOption();
                    else
                        Chess_PromotionHandler(arg);
                    break;
                case "orange":
                    if (additionalChoiceFlag)
                    {
                        selectedOption = 1;
                        Interface_AnalysisHandler();
                    }
                    else if (gameState != 3)
                    {
                        if (!promotionFlag && selectedSquare[0] != -1)
                            Chess_FindNextValidMove();
                        else
                            Chess_PromotionHandler(arg);
                    }
                    break;
                case "red":
                    if (additionalChoiceFlag)
                    {
                        selectedOption = 2;
                        if (gameState == 2)
                            Interface_AnalysisHandler();
                        else
                            Interface_MenuHandler();
                    }
                    else if (gameState == 0 || gameState == 1)
                    {
                        if (selectedOption >= 0)
                            Interface_InGameHandler();
                        else if (!promotionFlag)
                        {
                            if (selectedSquare[0] != selectedPiece[0] || selectedSquare[1] != selectedPiece[1])
                            {
                                sPosX = selectedSquare[0];
                                sPosY = selectedSquare[1];
                                Chess_PerformMove();
                                selectedPiece[0] = selectedPiece[1] = selectedSquare[0] = selectedSquare[1] = -1;
                                for (int i = 0; i < 8; i++)
                                    for (int j = 0; j < 8; j++)
                                        possibleSquares[i, j] = false;
                            }
                        }
                        else
                            Chess_PromotionHandler(arg);
                    }
                    else if (gameState == 2)
                    {
                        if (selectedOption >= 0)
                            Interface_AnalysisHandler();
                        else if (!promotionFlag)
                        {
                            if (selectedSquare[0] != selectedPiece[0] || selectedSquare[1] != selectedPiece[1])
                            {
                                sPosX = selectedSquare[0];
                                sPosY = selectedSquare[1];
                                Chess_PerformMove();
                                selectedPiece[0] = selectedPiece[1] = selectedSquare[0] = selectedSquare[1] = -1;
                                for (int i = 0; i < 8; i++)
                                    for (int j = 0; j < 8; j++)
                                        possibleSquares[i, j] = false;
                            }
                        }
                        else
                            Chess_PromotionHandler(arg);
                    }
                    else
                        Interface_MenuHandler();
                    break;
                case "option1":
                case "option2":
                case "option3":
                    selectedOption = int.Parse(arg.Substring(6));
                    if (gameState == 0 || gameState == 1)
                        Interface_InGameHandler();
                    else if (gameState == 2)
                        Interface_AnalysisHandler();
                    else
                        Interface_MenuHandler();
                    break;
                default:
                    break;
            }
    }
    LCD_DrawScreen();
}

public void Chess_FindNextValidOption()
{
    if (gameState == 3 || gameState == 0 || (!fullScreen && (selectedOption >= 0 || (turnNumber > -1 && (selectedPiece[0] + 1 == 8 && selectedPiece[1] + 1 == 8))) && selectedOption <= 1))
    {
        for (int i = 0; i < 8; i++)
            for (int j = 0; j < 8; j++)
                possibleSquares[i, j] = false;

        selectedPiece[0] = selectedPiece[1] = selectedSquare[0] = selectedSquare[1] = -1;
        if (gameState == 3)
        {
            if (menuChoice > chessNotationsList.Count + 1)
                menuChoice = 0;
            else
                menuChoice++;
        }
        else if (gameState == 0)
        {
            selectedOption++;
            if (selectedOption == 3)
                selectedOption = 0;
        }
        else
            selectedOption++;
    }
    else if (currSelectionTime > 0 || selectedPiece[0] == -1 || selectionLife == 0)
    {
        currSelectionTime = selectionLife;
        selectedOption = -1;
        selectedPiece[1] = (selectedPiece[1] + 1) % 8;
        selectedPiece[0] = selectedPiece[1] == 0 ? (selectedPiece[0] + 1) % 8 : selectedPiece[0];
        if (chessBoard[selectedPiece[0], selectedPiece[1]] != null && chessBoard[selectedPiece[0], selectedPiece[1]].color == whiteTurn && Chess_GetValidMoves(selectedPiece[0], selectedPiece[1]) > 0)
        {
            Runtime.UpdateFrequency |= UpdateFrequency.Update100;
            selectedSquare[0] = selectedPiece[0];
            selectedSquare[1] = selectedPiece[1];
        }
        else
            Chess_FindNextValidOption();
    }
    else if (selectionLife > 0)
    {
        Chess_GetValidMoves(selectedPiece[0], selectedPiece[1]);
        currSelectionTime = selectionLife;
        Runtime.UpdateFrequency |= UpdateFrequency.Update100;
    }      
}

public int Chess_GetValidMoves(int posX, int posY)
{
    for (int i = 0; i < 8; i++)
        for (int j = 0; j < 8; j++)
            possibleSquares[i, j] = false;

    int[] dirsX = { -1, -1, 1, 1, -1, 1, 0, 0, -2, -2, 2, 2, -1, -1, 1, 1 };
    int[] dirsY = { -1, 1, -1, 1, 0, 0, -1, 1, -1, 1, -1, 1, -2, 2, -2, 2 };

    string pieceType = chessBoard[posX, posY].type.ToString();
    int movesCount = 0;

    fPosX = selectedPiece[0];
    fPosY = selectedPiece[1];
    for (int i = 0; i < 16; i++)
        if ((pieceType == "Pawn" && (whiteTurn ? (i == 1 || i == 3 || i == 7) : (i == 0 || i == 2 || i == 6))) ||
            ((pieceType == "Queen" || pieceType == "King") && i >= 0 && i < 8) ||
            (pieceType == "Knight" && i >= 8 && i < 16) ||
            (pieceType == "Bishop" && i >= 0 && i < 4) ||
            (pieceType == "Rook" && i >= 4 && i < 8))
            if (Chess_IsWithinBounds(posX + dirsX[i], posY + dirsY[i]) && Chess_IsValidMove(posX, posY, posX + dirsX[i], posY + dirsY[i]))
            {
                possibleSquares[posX + dirsX[i], posY + dirsY[i]] = true;
                movesCount++;
                if ((pieceType != "King" && pieceType != "Pawn") || (pieceType == "King" && (i == 4 || i == 5)) || (pieceType == "Pawn" && (i == 6 || i == 7)))
                {
                    int checkX = posX + 2 * dirsX[i];
                    int checkY = posY + 2 * dirsY[i];
                    while (Chess_IsWithinBounds(checkX, checkY) && Chess_IsValidMove(posX, posY, checkX, checkY))
                    {
                        possibleSquares[checkX, checkY] = true;
                        movesCount++;
                        checkX += dirsX[i];
                        checkY += dirsY[i];
                    }
                }
            }

    return movesCount;
}

public void Chess_FindNextValidMove()
{
    //Cosmetically ordered move directions (clockwise search)
    int[] dirsX = { 0, 1, 1, 1, 0, -1, -1, -1, -2, -1, 1, 2, 2, 1, -1, -2 };
    int[] dirsY = { 1, 1, 0, -1, -1, -1, 0, 1, 1, 2, 2, 1, -1, -2, -2, -1 };

    string pieceType = chessBoard[selectedPiece[0], selectedPiece[1]].type.ToString();
    bool squareFoundFlag = false;

    if (currSelectionTime > 0 || selectedSquare[0] == -1 || selectionLife == 0)
    {
        for (int i = 0; i < 17; i++)
        {
            if ((pieceType == "Pawn" && (whiteTurn ? (savedDir == 0 || savedDir == 1 || savedDir == 7) : (savedDir == 3 || savedDir == 4 || savedDir == 5))) ||
                ((pieceType == "Queen" || pieceType == "King") && savedDir >= 0 && savedDir < 8) ||
                (pieceType == "Knight" && savedDir >= 8 && savedDir < 16) ||
                (pieceType == "Bishop" && (savedDir == 1 || savedDir == 3 || savedDir == 5 || savedDir == 7)) ||
                (pieceType == "Rook" && (savedDir == 0 || savedDir == 2 || savedDir == 4 || savedDir == 6)))
            {
                int checkX = selectedSquare[0] + dirsX[savedDir];
                int checkY = selectedSquare[1] + dirsY[savedDir];
                if (Chess_IsWithinBounds(checkX, checkY) && possibleSquares[checkX, checkY] == true)
                {
                    selectedSquare[0] = checkX;
                    selectedSquare[1] = checkY;
                    checkX += dirsX[savedDir];
                    checkY += dirsY[savedDir];
                    squareFoundFlag = true;
                }
                else
                {
                    savedDir = (savedDir + 1) % 16;
                    selectedSquare[0] = selectedPiece[0];
                    selectedSquare[1] = selectedPiece[1];
                }
            }
            else
                savedDir = (savedDir + 1) % 16;
            if (squareFoundFlag)
                break;
        }
        currSelectionTime = selectionLife;
    }
    else
        Chess_FindNextValidOption();
}

public void Chess_PerformMove()
{
    moveInfo = default(MoveInfo);
    ChessFigure chessPiece = chessBoard[fPosX, fPosY];
    moveInfo.pieceType = chessPiece.type;
    moveInfo.sourceX = fPosX;
    moveInfo.sourceY = fPosY;
    moveInfo.targetX = sPosX;
    moveInfo.targetY = sPosY;
    if (chessPiece.hasMoved == -1)
        chessPiece.hasMoved = turnNumber + 1;
    Chess_MoveChessPiece(chessPiece);
    if (chessPiece.type == ChessPiece.Pawn && (moveInfo.targetY == 0 || moveInfo.targetY == 7))
    {
        moveInfo.isPromotion = true;
        promotionFlag = true;
    }
    else if (animationSpeed > 0)
    {
        animationFlag = true;
        Runtime.UpdateFrequency |= UpdateFrequency.Update1;
    }
    else
        Chess_PerformMoveAfterMath();
}

public void Chess_PerformMoveAfterMath()
{
    turnNumber++;
    whiteTurn = !whiteTurn;
    if (moveInfo.isPromotion)
        chessBoard[moveInfo.targetX, moveInfo.targetY].type = moveInfo.promotedTo;
    moveInfo.isCheckmate = Chess_IsCheckmate();
    drawType = Chess_IsDraw();
    if (!loadGameFlag)
    {
        if (moveInfo.isCheckmate)
        {
            if (whiteTurn)
            {
                if (TB_White != null)
                    TB_White.StartCountdown();
                wLossType = 1;
            }
            else
            {
                if (TB_Black != null)
                    TB_Black.StartCountdown();
                bLossType = 1;
            }
        }
        else if (drawType > 0)
            moveInfo.isDraw = true;
        if (drawType > 0 || moveInfo.isCheckmate)
        {
            gameState = 0;
            for (int i = 0; i < 4; i++)
                messageFlags[i] = false;
            messageFlags[3] = true;
            if (isMusic)
                Sound_PlayMusic(true);
            LCDPanelTime = endOfGameMessageTime;
            Runtime.UpdateFrequency |= UpdateFrequency.Update100;
        }
        if (gameState == 2 && selectedOption == -1 && (divergenceTurn == -1 || turnNumber < chessNotation.Count))
        {
            if (divergenceTurn == -1)
                divergenceTurn = turnNumber;
            for (int i = chessMoves.Count - 1; i >= turnNumber; i--)
            {
                chessMoves.RemoveAt(i);
                chessNotation.RemoveAt(i);
            }
        }
        if (gameState == 0 || gameState == 1 || (gameState == 2 && divergenceTurn != -1))
        {
            Chess_WriteChessNotation();
            chessMoves.Add(moveInfo);
        }
    }
}

public bool Chess_IsValidMove(int sourceX, int sourceY, int targetX, int targetY)
{
    ChessFigure chessPiece = chessBoard[sourceX, sourceY];
    int distX = targetX - sourceX;
    int distY = targetY - sourceY;
    if (Chess_LeavesKingInDanger(sourceX, sourceY, targetX, targetY))
        return false;

    switch (chessPiece.type.ToString())
    {
        case "Pawn":
            if (distX == 0 && Chess_IsPathClear(sourceX, sourceY, targetX, targetY))
            {
                if (chessPiece.hasMoved == -1 && (chessPiece.color ? distY == 2 : distY == -2))
                    return true;
                if (chessPiece.color ? distY == 1 : distY == -1)
                    return true;
            }
            else if ((chessPiece.color ? distY == 1 : distY == -1) && Math.Abs(distX) == 1)
            {
                if (chessBoard[sourceX + distX, sourceY + distY] != null && chessBoard[sourceX + distX, sourceY + distY].color != chessPiece.color)
                    return true;
                if (chessBoard[sourceX + distX, sourceY] != null && chessBoard[sourceX + distX, sourceY].color != chessPiece.color && (chessPiece.color ? sourceY == 4 : sourceY == 3) && chessBoard[sourceX + distX, sourceY].hasMoved == turnNumber)
                    return true;
            }
            break;
        case "Rook":
            if ((distX == 0 || distY == 0) && Chess_IsPathClear(sourceX, sourceY, targetX, targetY))
                return true;
            break;
        case "Knight":
            if (((Math.Abs(distX) == 2 && Math.Abs(distY) == 1) || (Math.Abs(distX) == 1 && Math.Abs(distY) == 2)) && (chessBoard[targetX, targetY] == null || chessBoard[targetX, targetY].color != chessPiece.color))
                return true;
            break;
        case "Bishop":
            if (Math.Abs(distX) == Math.Abs(distY) && Chess_IsPathClear(sourceX, sourceY, targetX, targetY))
                return true;
            break;
        case "Queen":
            if ((Math.Abs(distX) == Math.Abs(distY) || distX == 0 || distY == 0) && Chess_IsPathClear(sourceX, sourceY, targetX, targetY))
                return true;
            break;
        case "King":
            if ((Math.Max(Math.Abs(distX), Math.Abs(distY)) <= 1 || (Math.Abs(distX) == 2 && distY == 0 && chessPiece.hasMoved == -1 && Chess_IsCastlingValid(chessPiece, distX))) && Chess_IsPathClear(sourceX, sourceY, targetX, targetY))
                return true;
            break;
    }
    return false;
}

public bool Chess_LeavesKingInDanger(int sourceX, int sourceY, int targetX, int targetY)
{
    ChessFigure chessPiece = chessBoard[sourceX, sourceY];
    ChessFigure saveChessPiece = chessBoard[targetX, targetY];
    int[] kingPos = chessPiece.color ? wKingPos.ToArray() : bKingPos.ToArray();

    chessBoard[targetX, targetY] = chessPiece;
    chessBoard[sourceX, sourceY] = null;
    if (chessPiece.type == ChessPiece.King ? Chess_CanMoveToCount(!chessPiece.color, targetX, targetY, true) == 0 : Chess_CanMoveToCount(!chessPiece.color, kingPos[0], kingPos[1], true) == 0)
    {
        chessBoard[targetX, targetY] = saveChessPiece;
        chessBoard[sourceX, sourceY] = chessPiece;
        return false;
    }
    else
    {
        chessBoard[targetX, targetY] = saveChessPiece;
        chessBoard[sourceX, sourceY] = chessPiece;
        return true;
    }
}

public int Chess_CanMoveToCount(bool color, int posX, int posY, bool searchEnemies)
{
    int[] dirsX = { -1, -1, 1, 1, -1, 1, 0, 0, -2, -2, 2, 2, -1, -1, 1, 1 };
    int[] dirsY = { -1, 1, -1, 1, 0, 0, -1, 1, -1, 1, -1, 1, -2, 2, -2, 2 };
    int checkX, checkY, iteration;
    int counter = 0;

    for (int i = 0; i < 16; i++)
    {
        iteration = 0;
        checkX = posX + dirsX[i];
        checkY = posY + dirsY[i];

        while (Chess_IsWithinBounds(checkX, checkY))
        {
            ChessFigure chessPiece = chessBoard[checkX, checkY];
            if (chessPiece != null && chessPiece.color != color)
                break;
            else if (chessPiece != null)
            {
                string pieceType = chessPiece.type.ToString();
                if ((pieceType == "Pawn" && (searchEnemies ? (color ? (i == 0 || i == 2) : (i == 1 || i == 3)) && iteration == 0 : Chess_IsValidMove(checkX, checkY, posX, posY))) ||
                    (pieceType == "Knight" && i >= 8 && i < 16 && iteration == 0) ||
                    (pieceType == "King" && i >= 0 && i < 8 && iteration == 0) ||
                    (pieceType == "Bishop" && i >= 0 && i < 4) ||
                    (pieceType == "Rook" && i >= 4 && i < 8) ||
                    (pieceType == "Queen" && i >= 0 && i < 8))
                {
                    if (color == whiteTurn && !searchEnemies)
                    {
                        if (pieceType != "King" && !Chess_LeavesKingInDanger(checkX, checkY, posX, posY))
                            counter++;
                    }
                    else if (color != whiteTurn && searchEnemies)
                    {
                        counter++;
                        tempChessPiecePos[0] = checkX;
                        tempChessPiecePos[1] = checkY;
                    }
                }
                checkX += 100;
            }
            checkX += dirsX[i];
            checkY += dirsY[i];
            iteration++;
        }
    }
    return counter;
}

public bool Chess_IsWithinBounds(int posX, int posY)
{
    return posX >= 0 && posX < 8 && posY >= 0 && posY < 8;
}

public bool Chess_IsPathClear(int sourceX, int sourceY, int targetX, int targetY)
{
    ChessFigure chessPiece = chessBoard[sourceX, sourceY];
    int distX = targetX - sourceX;
    int distY = targetY - sourceY;

    int dirX = Math.Sign(distX);
    int dirY = Math.Sign(distY);

    for (int i = 1; i < Math.Max(Math.Abs(distX), Math.Abs(distY)); i++)
        if (chessBoard[sourceX + i * dirX, sourceY + i * dirY] != null)
            return false;
    if (chessPiece.type == ChessPiece.Pawn && chessBoard[targetX, targetY] != null)
        return false;
    if (chessBoard[targetX, targetY] != null && chessBoard[targetX, targetY].color == chessPiece.color)
        return false;
    return true;
}

public bool Chess_IsCastlingValid(ChessFigure chessPiece, int distX)
{
    int rookDistance = distX > 0 ? 3 : -4;
    if (Chess_CanMoveToCount(!chessPiece.color, fPosX, fPosY, true) == 0 && Chess_CanMoveToCount(!chessPiece.color, fPosX + Math.Sign(distX), fPosY, true) == 0)
        if (chessBoard[fPosX + rookDistance, fPosY] != null && chessBoard[fPosX + rookDistance, fPosY].type == ChessPiece.Rook && chessBoard[fPosX + rookDistance, fPosY].hasMoved == -1)
            return true;
    return false;
}

public void Chess_MoveChessPiece(ChessFigure chessPiece)
{
    if (chessPiece.type == ChessPiece.King)
    {
        if (chessPiece.color)
        {
            wKingPos[0] = sPosX;
            wKingPos[1] = sPosY;
        }
        else
        {
            bKingPos[0] = sPosX;
            bKingPos[1] = sPosY;
        }
    }
    if (chessPiece.type == ChessPiece.King && Math.Abs(moveInfo.targetX - moveInfo.sourceX) == 2)
    {
        if (loadGameFlag ? gameLoadSpeed <= 0 : animationSpeed <= 0)
        {
            chessBoard[sPosX, sPosY] = chessPiece;
            chessBoard[fPosX, fPosY] = null;
        }
        if (moveInfo.targetX - moveInfo.sourceX > 0)
        {
            if (loadGameFlag ? gameLoadSpeed <= 0 : animationSpeed <= 0)
            {
                chessPiece = chessBoard[7, fPosY];
                chessBoard[5, fPosY] = chessPiece;
                chessBoard[7, fPosY] = null;
            }
            moveInfo.isSCastling = true;
        }
        else
        {
            if (loadGameFlag ? gameLoadSpeed <= 0 : animationSpeed <= 0)
            {
                chessPiece = chessBoard[0, fPosY];
                chessBoard[3, sPosY] = chessPiece;
                chessBoard[0, fPosY] = null;
            }
            moveInfo.isLCastling = true;
        }
    }
    else
    {
        if (chessBoard[sPosX, sPosY] != null || (chessPiece.type == ChessPiece.Pawn && Math.Abs(moveInfo.targetX - moveInfo.sourceX) > 0))
        {
            moveInfo.isCapture = true;
            if (chessBoard[sPosX, sPosY] != null)
                moveInfo.capturedPiece = new ChessFigure(chessBoard[sPosX, sPosY]);
            else
            {
                moveInfo.isEnPassant = true;
                moveInfo.capturedPiece = new ChessFigure(chessBoard[sPosX, fPosY == 3 ? sPosY + 1 : sPosY - 1]);
                if (loadGameFlag ? gameLoadSpeed <= 0 : animationSpeed <= 0)
                    chessBoard[sPosX, fPosY == 3 ? sPosY + 1 : sPosY - 1] = null;
            }
        }
        if (loadGameFlag ? gameLoadSpeed <= 0 : animationSpeed <= 0)
        {
            chessBoard[sPosX, sPosY] = chessPiece;
            chessBoard[fPosX, fPosY] = null;
        }
    }
}

public bool Chess_IsCheckmate()
{
    int[] kingPos = whiteTurn ? wKingPos.ToArray() : bKingPos.ToArray();

    int currentAttacks = Chess_CanMoveToCount(!whiteTurn, kingPos[0], kingPos[1], true);
    if (currentAttacks == 0)
        return false;

    int[] savedtempChessPiecePos = tempChessPiecePos.ToArray();
    int[] dirsX = { -1, -1, 1, 1, -1, 1, 0, 0 };
    int[] dirsY = { -1, 1, -1, 1, 0, 0, -1, 1 };
    int checkX, checkY;
    moveInfo.isCheck = true;

    for (int i = 0; i < 8; i++)
    {
        checkX = kingPos[0] + dirsX[i];
        checkY = kingPos[1] + dirsY[i];
        if (Chess_IsWithinBounds(checkX, checkY) && (chessBoard[checkX, checkY] == null || chessBoard[checkX, checkY].color == !whiteTurn))
            if (!Chess_LeavesKingInDanger(kingPos[0], kingPos[1], checkX, checkY))
                return false;
    }
    if (currentAttacks == 1)
    {
        int dirX = Math.Sign(savedtempChessPiecePos[0] - kingPos[0]);
        int dirY = Math.Sign(savedtempChessPiecePos[1] - kingPos[1]);
        if (Math.Abs(kingPos[0] - savedtempChessPiecePos[0]) == 2 || Math.Abs(kingPos[1] - savedtempChessPiecePos[1]) == 2)
        {
            if (Chess_CanMoveToCount(whiteTurn, savedtempChessPiecePos[0], savedtempChessPiecePos[1], false) > 0)
                return false;
        }
        else
        {
            for (int i = 1; i <= Math.Max(Math.Abs(kingPos[0] - savedtempChessPiecePos[0]), Math.Abs(kingPos[1] - savedtempChessPiecePos[1])); i++)
            {
                checkX = kingPos[0] + i * dirX;
                checkY = kingPos[1] + i * dirY;
                if (Chess_CanMoveToCount(whiteTurn, checkX, checkY, false) > 0)
                {
                    return false;
                }
            }
        }
    }
    return true;
}

public int Chess_IsDraw()
{
    if (Chess_IsStalemate())
        return 1;
    fiftyMoveRuleCounter = (!moveInfo.isCapture && moveInfo.pieceType != ChessPiece.Pawn) ? fiftyMoveRuleCounter + 1 : 0;
    if (fiftyMoveRuleCounter == 100)
        return 2;
    if (Chess_IsThreefoldRepetition())
        return 3;
    if (Chess_IsInsufficientMaterial())
        return 4;
    return 0;
}

public bool Chess_IsStalemate()
{
    int[] kingPos = whiteTurn ? wKingPos : bKingPos;
    if (Chess_CanMoveToCount(!whiteTurn, kingPos[0], kingPos[1], true) > 0)
        return false;

    int[] dirsX = { -1, -1, 1, 1, -1, 1, 0, 0, -2, -2, 2, 2, -1, -1, 1, 1 };
    int[] dirsY = { -1, 1, -1, 1, 0, 0, -1, 1, -1, 1, -1, 1, -2, 2, -2, 2 };

    for (int i = 0; i < 8; i++)
        for (int j = 0; j < 8; j++)
            if (chessBoard[i, j] != null && chessBoard[i, j].color == whiteTurn)
                for (int k = 0; k < 16; k++)
                    if ((chessBoard[i, j].type == ChessPiece.Pawn && (whiteTurn ? (k == 1 || k == 3 || k == 7) : (k == 0 || k == 2 || k == 6))) ||
                        ((chessBoard[i, j].type == ChessPiece.Queen || chessBoard[i, j].type == ChessPiece.King) && k >= 0 && k < 8) ||
                        (chessBoard[i, j].type == ChessPiece.Knight && k >= 8 && k < 16) ||
                        (chessBoard[i, j].type == ChessPiece.Bishop && k >= 0 && k < 4) ||
                        (chessBoard[i, j].type == ChessPiece.Rook && k >= 4 && k < 8))
                        if (Chess_IsWithinBounds(i + dirsX[k], j + dirsY[k]) && Chess_IsValidMove(i, j, i + dirsX[k], j + dirsY[k]))
                            return false;
    return true;
}

public bool Chess_IsThreefoldRepetition()
{
    string lastPosition = "";
    int counter = 1;
    for (int i = 0; i < 8; i++)
        for (int j = 0; j < 8; j++)
        {
            if (chessBoard[i, j] == null)
                lastPosition += "-";
            else
            {
                lastPosition += chessBoard[i, j].color ? "w" : "b";
                lastPosition += chessBoard[i, j].type == ChessPiece.Knight ? "N" : $"{chessBoard[i, j].type.ToString()[0]}";
            }
        }
    for (int i = 0; i < positionKeys.Count; i++)
    {
        if (positionKeys[i] == lastPosition)
            counter++;
        if (counter == 3)
            return true;
    }
    positionKeys.Add(lastPosition);
    return false;
}

struct ChessPieceInfo
{
    public ChessPiece type { get; set; }
    public int x { get; set; }
    public int y { get; set; }

    public ChessPieceInfo(ChessPiece type, int x, int y)
    {
        this.type = type;
        this.x = x;
        this.y = y;
    }
}

public bool Chess_IsInsufficientMaterial()
{
    List<ChessPieceInfo> wPieces = new List<ChessPieceInfo>();
    List<ChessPieceInfo> bPieces = new List<ChessPieceInfo>();

    for (int i = 0; i < 8; i++)
        for (int j = 0; j < 8; j++)
            if (chessBoard[i, j] != null)
                (chessBoard[i, j].color ? wPieces : bPieces).Add(new ChessPieceInfo(chessBoard[i, j].type, i, j));

    if (wPieces.Count == 1 && bPieces.Count == 1)
        return true;
    if (wPieces.Count == 2 && bPieces.Count == 1)
    {
        if (wPieces[0].type == ChessPiece.Bishop || wPieces[1].type == ChessPiece.Bishop)
            return true;
        if (wPieces[0].type == ChessPiece.Knight || wPieces[1].type == ChessPiece.Knight)
            return true;
    }
    else if (wPieces.Count == 1 && bPieces.Count == 2)
    {
        if (bPieces[0].type == ChessPiece.Bishop || bPieces[1].type == ChessPiece.Bishop)
            return true;
        if (bPieces[0].type == ChessPiece.Knight || bPieces[1].type == ChessPiece.Knight)
            return true;
    }
    if (wPieces.Count == 2 && bPieces.Count == 2)
        if ((wPieces[0].type == ChessPiece.Bishop || wPieces[1].type == ChessPiece.Bishop) && (bPieces[0].type == ChessPiece.Bishop || bPieces[1].type == ChessPiece.Bishop))
        {
            int wBishopFormula = wPieces[0].type == ChessPiece.Bishop ? wPieces[0].x + wPieces[0].y : wPieces[1].x + wPieces[1].y;
            int bBishopFormula = bPieces[0].type == ChessPiece.Bishop ? bPieces[0].x + bPieces[0].y : bPieces[1].x + bPieces[1].y;
            if ((wBishopFormula % 2) == (bBishopFormula % 2))
                return true;
        }
    return false;
}

public void Chess_PromotionHandler(string arg)
{
    if (arg == "orange")
        promotionPiece = ((int)promotionPiece + 1) == 5 ? (ChessPiece)(1) : (ChessPiece)((int)promotionPiece + 1);
    else if (arg == "red")
    {
        moveInfo.promotedTo = promotionPiece;
        promotionPiece = ChessPiece.Queen;
        promotionFlag = false;
        if (animationSpeed > 0)
        {
            animationFlag = true;
            Runtime.UpdateFrequency |= UpdateFrequency.Update1;
        }
        else
            Chess_PerformMoveAfterMath();
    }
    else if (arg == "green")
    {
        moveInfo = default(MoveInfo);
        promotionFlag = false;
        promotionPiece = ChessPiece.Queen;
    }
}

public void Chess_WriteChessNotation()
{
    string lastMove;
    string sourceSquare = $"{(char)(97 + moveInfo.sourceX)}{(char)(49 + moveInfo.sourceY)}";
    string targetSquare = $"{(char)(97 + moveInfo.targetX)}{(char)(49 + moveInfo.targetY)}";

    if (moveInfo.isSCastling || moveInfo.isLCastling)
        lastMove = moveInfo.isSCastling ? "0-0" : "0-0-0";
    else if (moveInfo.pieceType == ChessPiece.Pawn)
        lastMove = $"{(moveInfo.isCapture ? sourceSquare[0] + 'x'.ToString() : "")}{targetSquare[0]}{targetSquare[1]}{(moveInfo.isPromotion ? '='.ToString() + moveInfo.promotedTo.ToString()[0] : "")}";
    else
    {
        if (moveInfo.pieceType == ChessPiece.Knight)
            lastMove = "N";
        else
            lastMove = $"{moveInfo.pieceType.ToString()[0]}";
        if (Chess_IsNotationDiscrepancy(moveInfo.sourceX, moveInfo.sourceY, moveInfo.targetX, moveInfo.targetY, true) || Chess_IsNotationDiscrepancy(moveInfo.sourceX, moveInfo.sourceY, moveInfo.targetX, moveInfo.targetY, false))
        {
            if (moveInfo.pieceType == ChessPiece.Queen && Chess_IsNotationDiscrepancy(moveInfo.sourceX, moveInfo.sourceY, moveInfo.targetX, moveInfo.targetY, false)
                && Chess_IsNotationDiscrepancy(moveInfo.sourceX, moveInfo.sourceY, moveInfo.targetX, moveInfo.targetY, true))
                lastMove += $"{sourceSquare[0]}{sourceSquare[1]}";
            else if (!Chess_IsNotationDiscrepancy(moveInfo.sourceX, moveInfo.sourceY, moveInfo.targetX, moveInfo.targetY, false))
                lastMove += $"{sourceSquare[0]}";
            else
                lastMove += $"{sourceSquare[1]}";
        }
        if (moveInfo.isCapture)
            lastMove += "x";
        lastMove += $"{targetSquare[0]}{targetSquare[1]}";
    }
    if (moveInfo.isCheckmate)
    {
        lastMove += "#";
    }
    else if (moveInfo.isCheck)
    {
        lastMove += "+";
    }
    chessNotation.Add(lastMove);
}

public bool Chess_IsNotationDiscrepancy(int sourceX, int sourceY, int targetX, int targetY, bool scanHorizontal)
{
    int checkX, checkY;
    ChessFigure saveChessPiece = chessBoard[targetX, targetY];
    chessBoard[sourceX, sourceY] = saveChessPiece;
    chessBoard[targetX, targetY] = null;

    for (int i = 0; i < 8; i++)
    {
        checkX = scanHorizontal ? i : sourceX;
        checkY = !scanHorizontal ? i : sourceY;
        if (!(checkX == sourceX && checkY == sourceY) && chessBoard[checkX, checkY] != null && chessBoard[checkX, checkY].color == chessBoard[sourceX, sourceY].color && chessBoard[checkX, checkY].type == moveInfo.pieceType)
            if (Chess_IsValidMove(checkX, checkY, targetX, targetY))
            {
                chessBoard[sourceX, sourceY] = null;
                chessBoard[targetX, targetY] = saveChessPiece;
                return true;
            }
    }
    chessBoard[sourceX, sourceY] = null;
    chessBoard[targetX, targetY] = saveChessPiece;
    return false;
}

public void Chess_InitializeGame()
{
    bool isWhite;
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            isWhite = j < 2;
            ChessPiece pieceType = ChessPiece.Pawn;
            if (j == 0 || j == 7)
            {
                switch (i)
                {
                    case 0:
                    case 7:
                        pieceType = ChessPiece.Rook;
                        break;
                    case 1:
                    case 6:
                        pieceType = ChessPiece.Knight;
                        break;
                    case 2:
                    case 5:
                        pieceType = ChessPiece.Bishop;
                        break;
                    case 3:
                        pieceType = ChessPiece.Queen;
                        break;
                    case 4:
                        pieceType = ChessPiece.King;
                        break;
                }
            }
            if (j == 0 || j == 1 || j == 6 || j == 7)
                chessBoard[i, j] = new ChessFigure(pieceType, isWhite);
            else
                chessBoard[i, j] = null;
            possibleSquares[i, j] = false;
        }
    }
    LCDPanelTime = 0;
    turnNumber = -1;
    whiteTurn = true;
    promotionFlag = false;
    wKingPos[0] = bKingPos[0] = 4;
    wKingPos[1] = 0;
    bKingPos[1] = 7;
    for (int i = 0; i < 4; i++)
        messageFlags[i] = false;
    selectedPiece[0] = selectedPiece[1] = selectedSquare[0] = selectedSquare[1] = -1;
    selectedOption = -1;
    chessNotation.Clear();
    chessMoves.Clear();
    positionKeys.Clear();
    fiftyMoveRuleCounter = 0;
    drawType = wLossType = bLossType = 0;

    LCD_DrawScreen();
}

public void Chess_LoadMove()
{
    moveInfo = chessMoves[turnNumber + 1];
    fPosX = moveInfo.sourceX;
    fPosY = moveInfo.sourceY;
    sPosX = moveInfo.targetX;
    sPosY = moveInfo.targetY;
    ChessFigure chessPiece = chessBoard[moveInfo.sourceX, moveInfo.sourceY];
    chessPiece.hasMoved = turnNumber + 1;
    Chess_MoveChessPiece(chessPiece);
    if (loadGameFlag ? gameLoadSpeed > 0 : animationSpeed > 0)
    {
        animationFlag = true;
        Runtime.UpdateFrequency |= UpdateFrequency.Update1;
    }
    else
        Chess_PerformMoveAfterMath();
}

public void Chess_TakeBack()
{
    moveInfo = chessMoves[turnNumber];
    chessBoard[moveInfo.sourceX, moveInfo.sourceY] = chessBoard[moveInfo.targetX, moveInfo.targetY];
    chessBoard[moveInfo.targetX, moveInfo.targetY] = null;
    ChessFigure chessPiece = chessBoard[moveInfo.sourceX, moveInfo.sourceY];

    if (chessPiece.hasMoved == turnNumber)
        chessPiece.hasMoved = -1;
    if (moveInfo.isPromotion)
        chessPiece.type = ChessPiece.Pawn;
    if (moveInfo.isEnPassant)
        chessBoard[moveInfo.targetX, moveInfo.targetY == 5 ? moveInfo.targetY - 1 : moveInfo.targetY + 1] = new ChessFigure(moveInfo.capturedPiece);
    else if (moveInfo.isCapture)
        chessBoard[moveInfo.targetX, moveInfo.targetY] = new ChessFigure(moveInfo.capturedPiece);
    else
        chessBoard[moveInfo.targetX, moveInfo.targetY] = null;

    if (moveInfo.isLCastling)
    {
        chessBoard[0, moveInfo.sourceY] = chessBoard[3, moveInfo.sourceY];
        chessBoard[3, moveInfo.sourceY] = null;
    }
    else if (moveInfo.isSCastling)
    {
        chessBoard[7, moveInfo.sourceY] = chessBoard[5, moveInfo.sourceY];
        chessBoard[5, moveInfo.sourceY] = null;
    }
    if (chessPiece.type == ChessPiece.King)
    {
        if (!whiteTurn)
        {
            wKingPos[0] = moveInfo.sourceX;
            wKingPos[1] = moveInfo.sourceY;
        }
        else
        {
            bKingPos[0] = moveInfo.sourceX;
            bKingPos[1] = moveInfo.sourceY;
        }
    }
    fiftyMoveRuleCounter = (!moveInfo.isCapture && moveInfo.pieceType != ChessPiece.Pawn) ? fiftyMoveRuleCounter - 1 : 0;
    whiteTurn = !whiteTurn;
    positionKeys.RemoveAt(positionKeys.Count - 1);
    if (turnNumber == divergenceTurn)
    {
        if (menuChoice > 2)
        {
            chessNotation = chessNotationsList[menuChoice - 3].ToList();
            chessMoves = chessMovesList[menuChoice - 3].ToList();
        }
        else
        {
            chessNotation = chessNotationsList[chessNotationsList.Count - 1].ToList();
            chessMoves = chessMovesList[chessMovesList.Count - 1].ToList();
        }
        divergenceTurn = -1;
    }
    turnNumber--;
    promotionFlag = false;
    promotionPiece = ChessPiece.Queen;
    drawType = wLossType = bLossType = 0;
    Sound_PlayGameSounds(true);
}

public void Chess_DrawAnimation(ChessFigure chessPiece)
{
    animationCounter = (animationCounter + 1) % (loadGameFlag ? gameLoadSpeed + 9 : animationSpeed + 9);
    if (animationCounter == 0)
    {
        if (isSound)
            Sound_PlayGameSounds(true);
        if (fPosX != sPosX || fPosY != sPosY)
        {
            if (chessPiece.type == ChessPiece.Knight)
            {
                if (tempChessPiece != null)
                {
                    chessBoard[fPosX, fPosY] = tempChessPiece;
                    tempChessPiece = null;
                }
                else
                    chessBoard[fPosX, fPosY] = null;

                int destX = Math.Sign(sPosX - fPosX);
                int destY = Math.Sign(sPosY - fPosY);
                if (Math.Abs(moveInfo.targetX - moveInfo.sourceX) == 2)
                {
                    if (fPosX != sPosX)
                    {
                        fPosX += destX;
                        if (!knightsFullMove && Math.Abs(sPosX - fPosX) == 0)
                            fPosY += destY;
                    }
                    else
                        fPosY += destY;
                }
                else if (Math.Abs(moveInfo.targetY - moveInfo.sourceY) == 2)
                {
                    if (fPosY != sPosY)
                    {
                        fPosY += destY;
                        if (!knightsFullMove && Math.Abs(sPosY - fPosY) == 0)
                            fPosX += destX;
                    }
                    else
                        fPosX += destX;
                }
                if (chessBoard[fPosX, fPosY] != null)
                    tempChessPiece = chessBoard[fPosX, fPosY];
                chessBoard[fPosX, fPosY] = chessPiece;
            }
            else if ((moveInfo.isSCastling && (chessBoard[7, fPosY] != null || (chessBoard[6, fPosY] != null && chessBoard[6, fPosY].type == ChessPiece.Rook))) || (moveInfo.isLCastling && (chessBoard[0, fPosY] != null || chessBoard[1, fPosY] != null || (chessBoard[2, fPosY] != null && chessBoard[2, fPosY].type == ChessPiece.Rook))))
            {
                if (moveInfo.isSCastling)
                {
                    int rookSquare = 7;
                    while (chessBoard[rookSquare, fPosY] == null)
                        rookSquare--;
                    chessBoard[rookSquare - 1, fPosY] = chessBoard[rookSquare, fPosY];
                    chessBoard[rookSquare, fPosY] = null;
                }
                else
                {
                    int rookSquare = 0;
                    while (chessBoard[rookSquare, fPosY] == null)
                        rookSquare++;
                    chessBoard[rookSquare + 1, fPosY] = chessBoard[rookSquare, fPosY];
                    chessBoard[rookSquare, fPosY] = null;
                }
            }
            else
            {
                int dirX = Math.Sign(sPosX - fPosX);
                int dirY = Math.Sign(sPosY - fPosY);
                if (moveInfo.isSCastling || moveInfo.isLCastling)
                    dirX *= 2;
                fPosX += dirX;
                fPosY += dirY;
                chessBoard[fPosX, fPosY] = chessPiece;
                chessBoard[fPosX - dirX, fPosY - dirY] = null;
            }
        }
        else
        {
            tempChessPiece = null;
            if (moveInfo.isEnPassant)
                chessBoard[sPosX, fPosY == 3 ? sPosY + 1 : sPosY - 1] = null;
            if (!loadGameFlag)
                Runtime.UpdateFrequency &= ~UpdateFrequency.Update1;
            animationFlag = false;   
            if (isSound)
                Sound_PlayGameSounds(true);
            Chess_PerformMoveAfterMath();
            fPosX = fPosY = sPosX = sPosY = -1;
        }
    }
}

public void Interface_InGameHandler()
{
    if (gameState == 1)
    {
        if (selectedOption == 0)
        {
            Runtime.UpdateFrequency |= UpdateFrequency.Update100;
            LCDPanelTime = endOfGameMessageTime;
            gameState = 0;
            messageFlags[3] = true;
            if (whiteTurn)
            {
                if (TB_White != null)
                    TB_White.StartCountdown();
                wLossType = 2;
            }
            else
            {
                if (TB_Black != null)
                    TB_Black.StartCountdown();
                bLossType = 2;
            }
            if (isMusic)
                Sound_PlayMusic(true);
        }
        else if (selectedOption == 1)
        {
            Runtime.UpdateFrequency |= UpdateFrequency.Update100;
            LCDPanelTime = endOfGameMessageTime;
            drawType = 5;
            gameState = 0;
            messageFlags[3] = true;
            if (isMusic)
                Sound_PlayMusic(true);
        }
        else
        {
            Chess_TakeBack();
            chessNotation.RemoveAt(chessNotation.Count - 1);
            chessMoves.RemoveAt(chessMoves.Count - 1);
        }
    }
    else if (chessNotation.Count > 0 || chessNotationsList.Count > 0)
    {
        if (selectedOption == 0)
        {
            Chess_InitializeGame();
            gameState = 1;
        }
        else if (selectedOption == 1)
            gameState = 3;
        else if (selectedOption == 2)
        {
            Runtime.UpdateFrequency |= UpdateFrequency.Update1;
            loadGameFlag = true;
            chessNotationsList.Add(chessNotation.ToList());
            chessMovesList.Add(chessMoves.ToList());
            Chess_InitializeGame();
            chessNotation = chessNotationsList[chessNotationsList.Count - 1].ToList();
            chessMoves = chessMovesList[chessMovesList.Count - 1].ToList();
            gameState = 2;
        }
    }
}

public void Interface_AnalysisHandler()
{
    if (additionalChoiceFlag)
    {
        if (selectedOption == 0 || selectedOption == 2)
        {
            if (selectedOption == 0)
            {
                chessMovesList.Add(chessMoves.ToList());
                chessNotationsList.Add(chessNotation.ToList());
                enterNameFlag = true;
            }
            menuChoice = 0;
            gameState = 0;
            divergenceTurn = -1;
        }
        additionalChoiceFlag = false;
    }
    else
    {
        if (selectedOption == 0)
        {
            if (drawType == 0 && wLossType == 0 && bLossType == 0 && turnNumber != chessNotation.Count - 1)
                Chess_LoadMove();
        }
        else if (selectedOption == 1)
        {
            if (turnNumber >= 0)
                Chess_TakeBack();
        }
        else if (selectedOption == 2)
        {
            if (chessNotationsList.Count > chessGamesNameList.Count)
            {
                chessNotationsList.RemoveAt(chessNotationsList.Count - 1);
                chessMovesList.RemoveAt(chessMovesList.Count - 1);
            }
            if (divergenceTurn != -1 && chessNotation.Count - divergenceTurn > minTurnToSave && !chessNotationsList.Any(list => list.SequenceEqual(chessNotation.ToList())))
                additionalChoiceFlag = true;
            else
            {
                menuChoice = 0;
                gameState = 0;
            }
        }
    }
}

public void Interface_MenuHandler()
{
    if (additionalChoiceFlag)
    {
        if (selectedOption == 0)
        {
            Runtime.UpdateFrequency |= UpdateFrequency.Update1;
            loadGameFlag = true;
            Chess_InitializeGame();
            chessNotation = chessNotationsList[menuChoice - 3].ToList();
            chessMoves = chessMovesList[menuChoice - 3].ToList();
            gameState = 2;
        }
        else if (selectedOption == 1)
            additionalChoiceFlag = false;
        else
        {
            chessGamesNameList.RemoveAt(menuChoice - 3);
            chessNotationsList.RemoveAt(menuChoice - 3);
            chessMovesList.RemoveAt(menuChoice - 3);
            menuChoice = 0;
        }
        additionalChoiceFlag = false;
    }
    else
    {
        if (menuChoice == 0)
            gameState = 0;
        else if (menuChoice == 1)
        {
            if (!chessNotationsList.Any(list => list.SequenceEqual(chessNotation.ToList())) && chessNotation.Count > minTurnToSave)
            {
                chessMovesList.Add(chessMoves.ToList());
                chessNotationsList.Add(chessNotation.ToList());
                enterNameFlag = true;
            }
            else
            {
                Runtime.UpdateFrequency |= UpdateFrequency.Update100;
                if (chessNotation.Count > 5)
                    messageFlags[1] = true;
                else
                    messageFlags[0] = true;
                LCDPanelTime = errorMessageTime;
            }
        }
        else if (menuChoice == 2)
        {
            chessNotationsList.Clear();
            chessMovesList.Clear();
            chessGamesNameList.Clear();
        }
        else if (menuChoice < chessNotationsList.Count + 3)
            additionalChoiceFlag = true;
    }
}

public void LCD_DrawScreen()
{
    string screen = "", tempString = "";
    if (LCDPanelTime > 0 || enterNameFlag || additionalChoiceFlag)
    {
        panel.FontSize = 0.95F;
        screen += LCD_DrawMessage();
    }
    else
    {
        if (gameState == 3)
        {
            panel.FontSize = 0.95F;
            for (int i = Math.Max(menuChoice - 10, 0); i < Math.Max(menuChoice - 10, 0) + 15; i++)
            {
                if (i == 3)
                    tempString += LCD_DrawAsciiLine();
                else
                {
                    tempString += $"  {((menuChoice == i && i < 3) || (menuChoice == i - 1 && i > 3) ? "-> " : "    ")}";
                    if (i == 0)
                        tempString += "Exit\n";
                    else if (i == 1)
                        tempString += "Save current game\n";
                    else if (i == 2)
                        tempString += "Delete all games\n";
                    else if (i < chessNotationsList.Count + 4)
                        tempString += chessGamesNameList[i - 4] + "\n";
                    else
                        tempString += "\n";
                }
            }
        }
        else
        {
            panel.FontSize = fullScreen ? 0.124F : 0.108F;
            screen += LCD_DrawBoard();
        }          

        if (!fullScreen || (gameState == 3 && !additionalChoiceFlag && !enterNameFlag))
            screen += tempString + "\n\n" + LCD_DrawOptions();
    }
    
    panel.WriteText(screen);
}

public string LCD_DrawMessage()
{
    string tempString = "";
    if (!enterNameFlag && !additionalChoiceFlag)
    {
        for (int i = 0; i < 4; i++)
        {
            if (messageFlags[i])
            {
                switch (i)
                {
                    case 0:
                        tempString += $" Game too short to save! \n\n(At least {minTurnToSave} moves required!)";
                        break;
                    case 1:
                        tempString += "\n     Game already saved!\n";
                        break;
                    case 2:
                        tempString += "\nThis name is already taken!\n";
                        break;
                    case 3:
                        if (wLossType > 0)
                        {
                            switch (wLossType)
                            {
                                case 1:
                                    tempString += "         Checkmate! \n\n       Black wins!";
                                    break;
                                case 2:
                                    tempString += "      White resigned! \n\n       Black wins!";
                                    break;
                            }
                        }
                        else if (bLossType > 0)
                        {
                            switch (bLossType)
                            {
                                case 1:
                                    tempString += "         Checkmate! \n\n       White wins!"; 
                                    break;
                                case 2:
                                    tempString += "      Black resigned! \n\n       White wins!";
                                    break;
                            }
                        }
                        else if (drawType > 0)
                        {
                            switch (drawType)
                            {
                                case 1:
                                    tempString += "\n      Draw by stalemate!\n";
                                    break;
                                case 2:
                                    tempString += "\n    Draw by 50-move rule!\n";
                                    break;
                                case 3:
                                    tempString += "\nDraw by threefold repetition!\n";
                                    break;
                                case 4:
                                    tempString += "\nDraw by insufficient material!\n";
                                    break;
                                case 5:
                                    tempString += "\n    Draw by agreement!\n";
                                    break;
                            }
                        }
                        break;
                }
                break;
            }
        }
    }
    else if (enterNameFlag)
    {
        panel.FontSize = 0.7F;
        tempString += "    Please type in the game's name \n\n(Run the progr. block with said name)";
    }
    else
    {
        panel.FontSize = 0.59F;
        if (gameState == 2)
            tempString += "\n  Would you like to save the modified game?\n\n" + "  |   Save   |                  |   Exit   |";
        else
            tempString += "\n Would you like to load or delete this game?\n\n" + " |   Load   |   |  Cancel  |   |  Delete  |";
    }
    return LCD_DrawSpace(enterNameFlag ? 8 : additionalChoiceFlag ? 10 : 4) + LCD_DrawAsciiLine() + LCD_DrawSpace(2) + tempString + LCD_DrawSpace(3) + LCD_DrawAsciiLine();
}

//Ive literally no idea and no longer remember how the code below works

public string LCD_DrawBoard()
{
    string chessBoard = "";
    if ((boardRotation + 2 + (boardRotates ? (turnNumber + 1) * 2 : 0)) % 4 == 2 || (boardRotation + 2 + (boardRotates ? (turnNumber + 1) * 2 : 0)) % 4 == 1)
        for (int i = 7; i >= 0; i--)
            chessBoard += LCD_DrawBoardLine(i);
    else
        for (int i = 0; i < 8; i++)
            chessBoard += LCD_DrawBoardLine(i);

    if (promotionFlag)
        chessBoard = LCD_DrawPromotionOptions(chessBoard);

    return chessBoard;
}

public string LCD_DrawOptions()
{
    string options = "";

    if (gameState == 0 && (chessNotation.Count > 0 || chessNotationsList.Count > 0))
        options += LCD_DrawText(beforeGameOptions);
    else if (gameState == 1 && turnNumber > -1)
        options += LCD_DrawText(inGameOptions);
    else if (gameState == 2)
        options += LCD_DrawText(analysisOptions);

    return options;
}

public string LCD_DrawText(string textToDisplay)
{
    string[] separator = new string[] { "\r\n" };
    List<string[]> letters = new List<string[]>();
    string textToWrite = "";

    for (int j = 0; j < textToDisplay.Length; j++)
        if (textToDisplay[j] != ' ')
            letters.Add(letterStrings[(int)textToDisplay[j] - 65].Split(separator, StringSplitOptions.None));

    for (int i = 0; i < 18; i++)
    {
        int word = 0;
        int letter = 0;
        for (int j = 0; j < textToDisplay.Length; j++)
            if (textToDisplay[j] != ' ')
            {
                if (j > 0 && textToDisplay[j - 1] == ' ')
                    word++;
                if (selectedOption == word - 1)
                    letters[letter][i] = letters[letter][i].Replace('', selectedOption == 0 ? leftButtonColor : selectedOption == 1 ? middleButtonColor : rightButtonColor);
                textToWrite += letters[letter][i];
                letter++;
            }
            else
                textToWrite += " ";

        textToWrite += "\n";
    }

    return textToWrite;
}

public string LCD_DrawBoardLine(int line)
{
    string[] squaresInfo = LCD_GetSquaresInfo(line);
    string[] separator = new string[] { "\r\n" };
    List<string[]> squares = new List<string[]>();
    string boardLine = "";

    //Recoloring
    for (int i = 0; i < 8; i++)
    {
        int index = ((boardRotation + 2 + (boardRotates ? (turnNumber + 1) * 2: 0)) % 4 == 0) ? 7 - i : i;
        squares.Add(imageStrings[int.Parse(squaresInfo[index].Substring(0, 2))].Split(separator, StringSplitOptions.None));
        if (squaresInfo[index][3] == 'b')
            for (int j = 0; j < 18; j++)
                squares[i][j] = squares[i][j].Replace(savedWhiteColor, 't').Replace(savedBlackColor, squaresInfo[index][3] == 'b' ? newWhiteColor : newBlackColor).Replace('t', squaresInfo[index][3] == 'b' ? newBlackColor : newWhiteColor);
        if (squaresInfo[index][2] == '2')
            for (int j = 0; j < 18; j++)
                squares[i][j] = squares[i][j].Replace(savedLightSquareColor, squaresInfo[index][4] == 'w' ? newSelectedLightSquareColor : newSelectedDarkSquareColor);
        else
            if (squaresInfo[index][2] == '1' || squaresInfo[index][2] == '3')
                for (int j = 0; j < 18; j++)
                    squares[i][j] = squares[i][j].Replace(savedLightSquareColor, squaresInfo[index][4] == 'b' ? newDarkSquareColor : newLightSquareColor).Replace(savedSelectedLightSquareColor, squaresInfo[index][4] == 'b' ? newSelectedDarkSquareColor : newSelectedLightSquareColor);
            else
                for (int j = 0; j < 18; j++)
                    squares[i][j] = squares[i][j].Replace(savedLightSquareColor, squaresInfo[index][4] == 'b' ? newDarkSquareColor : newLightSquareColor);
    }

    for (int i = 0; i < 18; i++)
    {
        for (int j = 0; j < 8; j++)
            boardLine += (!fullScreen && j == 0 ? "               " : "") + squares[j][i] + (!fullScreen && j == 7 ? "               " : "");
        boardLine += '\n';
    }
    return boardLine;
}

public string[] LCD_GetSquaresInfo(int line)
{
    bool isVertical = boardRotation % 2 == 0 ? true : false;
    int col = isVertical ? 0 : line;
    int row = isVertical ? line : 0;
    string[] squaresInfo = new string[8]; //index (2 chars); squareState (0 none, 1 possible, 2 selected, 3 special) ; pieceColor (b/w); squareColor (b/w)
    for (int i = 0; i < 8; i++)
    {
        ChessFigure chessSquare;
        string squareState = "";
        string squarePiece = "";
        string squareName = "";
        chessSquare = chessBoard[col, row];
        int index;

        //SQUARE STATE
        if (((col == selectedPiece[0] && row == selectedPiece[1]) || (col == selectedSquare[0] && row == selectedSquare[1])) && (selectionLife == 0 || (selectionLife > 0 && currSelectionTime > 0)))
            squareState += "selected_";
        else if (possibleSquares[col, row] == true)
        {
            //Pawn promotion or enpassant
            if (chessBoard[selectedPiece[0], selectedPiece[1]].type == ChessPiece.Pawn && ((Math.Abs(col - selectedPiece[0]) == 1 && chessBoard[col, row] == null) || (col - selectedPiece[0] == 0 && (row == 7 || row == 0))))
                squareState += "special_";
            else
                squareState += "possible_";
        }
        //Rook highlighting in case of castling
        if (((col == 0 && possibleSquares[col + 2, row] == true) || (col == 7 && possibleSquares[col - 1, row] == true)) && chessBoard[selectedPiece[0], selectedPiece[1]].type == ChessPiece.King && selectedPiece[0] == 4)
            squareState += "possible_";
        //PIECE TYPE
        if (chessSquare != null)
            squarePiece += "w" + chessSquare.type.ToString() + "_";

        squareName += (squareState == "possible_" || squareState == "special_" ? squareState : "") + (squarePiece.Length > 0 ? squarePiece : "") + "wSquare";
        index = isVertical ? col : (boardRotation + 2 + (boardRotates ? (turnNumber + 1) * 2 : 0)) % 4 == 3 ? row : 7 - row;
        squaresInfo[index] = NameToIndex[squareName].ToString();
        squaresInfo[index] += squaresInfo[index].Length == 1 ? " " : "";

        switch (squareState)
        {
            case "possible_":
                squaresInfo[index] += "1";
                break;
            case "selected_":
                squaresInfo[index] += "2";
                break;
            case "special_":
                squaresInfo[index] += "3";
                break;
            default:
                squaresInfo[index] += "0";
                break;
        }
        squaresInfo[index] += chessSquare != null ? (chessSquare.color ? "w" : "b") : "0";
        squaresInfo[index] += (((col + row) % 2) + 0) % 2 == 1 ? "w" : "b";

        if (isVertical)
            col++;
        else
            row++;
    }

    return squaresInfo;
}

public string LCD_DrawPromotionOptions(string chessBoard)
{
    string[] pieces = new string[] { "Queen", "Rook", "Knight", "Bishop" };
    int[] squareIndices = LCD_GetPromotionSquareIndices(whiteTurn);
    string[] separator = new string[] { "\r\n" };
    List<string[]> squares = new List<string[]>();
    for (int i = 0; i < 4; i++)
    {
        squares.Add(imageStrings[squareIndices[i]].Split(separator, StringSplitOptions.None));
        if (!whiteTurn)
            for (int j = 0; j < 18; j++)
                squares[i][j] = squares[i][j].Replace(newWhiteColor, 't').Replace(newBlackColor, newWhiteColor).Replace('t', newBlackColor);
        if (pieces[i] == promotionPiece.ToString())
            for (int j = 0; j < 18; j++)
                squares[i][j] = squares[i][j].Replace(newLightSquareColor, newSelectedLightSquareColor);
    }


    bool isVertical = boardRotation % 2 == 0 ? true : false;
    bool isWhiteDownOrRight = isVertical ? (boardRotation + 2 + (boardRotates ? (turnNumber + 1) * 2 : 0)) % 4 == 2 : (boardRotation + 2 + (boardRotates ? (turnNumber + 1) * 2 : 0)) % 4 == 1;

    int charsToSkip = 0;
    if (isVertical)
    {
        //1305 = 18 * 9 * 8 + 9 ; 9081? = 18 * 18 * 8 * 3,5 + 9 //Just add some random numbers bro its easy
        if (isWhiteDownOrRight)
            charsToSkip = whiteTurn ? (1305 + (fullScreen ? 0 : 285)) : (9081 + (fullScreen ? 0 : 960));
        else
            charsToSkip = whiteTurn ? (9081 + (fullScreen ? 0 : 960)) : (1305 + (fullScreen ? 0 : 285));
    }
    else
        charsToSkip = 1305 + (fullScreen ? 0 : 285) + (isWhiteDownOrRight ? Math.Min(6, 7 - moveInfo.targetX) * (2592 + (fullScreen ? 0 : 555)) : Math.Min(moveInfo.targetX, 6) * (2592 + (fullScreen ? 0 : 555)));

    if (isVertical)
    {
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 18; j++)
            {
                int startIndex = charsToSkip + 18 * (isWhiteDownOrRight ? Math.Min(moveInfo.targetX, 6) + 1 : Math.Min(6, 7 - moveInfo.targetX) + 1) - 9;
                chessBoard = chessBoard.Remove(startIndex, 18);
                chessBoard = chessBoard.Insert(startIndex, squares[isWhiteDownOrRight ? (whiteTurn ? i : 3 - i) : (whiteTurn ? 3 - i : i)][j]);
                charsToSkip += 145 + (fullScreen ? 0 : 30);
            }
    }
    else
    {
        for (int i = 0; i < 18; i++)
        {
            int startIndex = charsToSkip + (isWhiteDownOrRight ? whiteTurn ? 0 : 54 : whiteTurn ? 54 : 0);
            chessBoard = chessBoard.Remove(startIndex, 72);
            for (int j = 0; j < 4; j++)
            {
                chessBoard = chessBoard.Insert(startIndex + 18 * j, squares[isWhiteDownOrRight ? (whiteTurn ? j : 3 - j) : (whiteTurn ? 3 - j : j)][i]);
            }
            charsToSkip += 145 + (fullScreen ? 0 : 30);
        }
    }

    return chessBoard;
}

public int[] LCD_GetPromotionSquareIndices(bool color)
{
    int[] squareIndices = new int[4];
    string[] pieces = new string[] { "Queen", "Rook", "Knight", "Bishop" };
    for (int i = 0; i < 4; i++)
    {
        string squareState = "";
        string squareName = "";
        squareState = pieces[i] == promotionPiece.ToString() ? "" : "possible_";
        squareName += squareState + "w" + pieces[i] + "_wSquare";
        squareIndices[i] = NameToIndex[squareName];
    }
    return squareIndices;
}

public string LCD_DrawAsciiLine()
{
    string line = "";
    for (int i = 0; i < 60; i++)
        line += "-";
    line += "\n";
    return line;
}

public string LCD_DrawSpace(int number)
{
    string space = "";
    for (int i = 0; i < number; i++)
        space += "\n";
    return space;
}

public void Sound_PlayGameSounds(bool isValidMove)
{
    if (animationFlag)
        foreach (IMySoundBlock block in soundBlocks)
        {
            block.SelectedSound = moveSound.SoundName;
            block.Volume = moveSound.Volume;
            block.Play();
        }
    else
    {
        foreach (IMySoundBlock block in soundBlocks)
        {
            block.SelectedSound = arrivalSound.SoundName;
            block.Volume = arrivalSound.Volume;
            block.Play();
        }
        if (moveInfo.isCheck)
            foreach (IMySoundBlock block in soundBlocks)
            {
                block.SelectedSound = checkSound.SoundName;
                block.Volume = checkSound.Volume;
                block.Play();
            }
        else if (moveInfo.isPromotion)
            foreach (IMySoundBlock block in soundBlocks)
            {
                block.SelectedSound = promotionSound.SoundName;
                block.Volume = promotionSound.Volume;
                block.Play();
            }
        else if (moveInfo.isCapture)
            foreach (IMySoundBlock block in soundBlocks)
            {
                block.SelectedSound = captureSound.SoundName;
                block.Volume = captureSound.Volume;
                block.Play();
            }
    }
    foreach (IMySoundBlock block in soundBlocks)
        block.Stop();
}

public void Sound_PlayMusic(bool activation)
{
    if (activation)
        foreach (IMySoundBlock block in soundBlocks)
        {
            block.SelectedSound = gameEndMusic.SoundName;
            block.Volume = gameEndMusic.Volume;
            block.Play();
        }
    else
        foreach (IMySoundBlock block in soundBlocks)
            block.Stop();
}