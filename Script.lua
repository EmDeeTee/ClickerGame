Quotes = {
	'"Hello" - Me',
	'"Goodbye" - Me',
	'"Its never too late to give up" - Me',
}

function OnGameStart() 
	 CreateAchievement("Get 100 points", "Farm 100 points")
end

function OnButtonClick(Points)
	return Points
end

function OnPointsChanged(Points) 
	if Points >= 100 then CompleteAchievement(GetAchievement("Get 100 points")) end	
	if Points == 69 then CompleteAchievement(GetAchievement("nice")) end	
end
