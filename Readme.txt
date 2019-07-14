************************************************************************************MSMQUEUE PROJECT

	GOAL
	
		Learn how to use the Microsoft MQUEUE on C# both in classic Framework and dot net core.
		
	
	Project scope
	
		Store meetins solicitations.
		
	
	Model
	
		Meeting solicitations Class
		
			MSolicitation.cs
			
				Id (int)
				Title (string)
				DateTimeStart (DateTime)
				DateTimeEnd (DateTime)
				MeetingTopics (string)
				NumberOfPeople (int)
				OwnerName (string)
				OwnerEmail (string)
				
		Architecture
		
			Request ==> Enqueue ==> Listener ==> Dequeue ==> Persist
			
		Visual Studio
		
			Solution
			
				NetMQueue
					NetMQueue.Model
						Class and persistence
						Class library
						
					ClassicDotNet (Folder)
						Folder to store classic dotnet projects
						
						NetMQueue.Classic.Api
							Endpoint to receive calls
							Aspnet.Api						
							
						NetMQueue.Classic.Queue
							Class library to enqueue and dequeue objects
							
						NetQueue.Classic.Daemons
							Console app to call enqueue and dequeue
							
							
					DotnetCore (Folder)
						Folder to store dotnet core projects
						
						NetMQueue.Core.Api
							Endpoint to receive calls
							Aspnet.Api						
							
						NetMQueue.Core.Queue
							Class library to enqueue and dequeue objects
							
						NetQueue.Core.Daemons
							Console app to call enqueue and dequeue
						