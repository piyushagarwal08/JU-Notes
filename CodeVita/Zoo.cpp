#include<iostream>
using namespace std;

int maximumCost(int,int,int,int,int,int,int,int,int);
int minimumCost(int,int,int,int,int,int);

int main()
{
	long int i_herbivoreCost,i_carnivoreCost,i_aquaticCost; // cost per sq m
	long int i_herbivoreMaxArea, i_carnivoreMaxArea, i_aquaticMaxArea; // max area allocation per habitat
	long int i_herbivoreMinAnimalCount, i_carnivoreAnimalCount, i_aquaticAnimalCount; // minimum animal count in a habitat
	long int i_herbivoreMinArea,i_carnivoreMinArea, i_aquaticMinArea;
	long int TotalArea; // on which land is to be built
	long int i_herbivoreArea=0,i_carnivoreArea=0,i_aquaticArea=0;
	long int MinimumCost,HMinCount,CMinCount,AMinCount;
	
	std::cin>>i_herbivoreCost>>i_carnivoreCost>>i_aquaticCost;
	std::cin>>i_herbivoreMaxArea>>i_carnivoreMaxArea>>i_aquaticMaxArea;
	std::cin>>i_herbivoreMinAnimalCount>>i_herbivoreMinArea;
	std::cin>>i_carnivoreAnimalCount>>i_carnivoreMinArea;
	std::cin>>i_aquaticAnimalCount>>i_aquaticMinArea;
	std::cin>>TotalArea;
	
	switch(maximumCost(i_herbivoreCost,i_carnivoreCost,i_aquaticCost,i_herbivoreMinAnimalCount,i_carnivoreAnimalCount,i_aquaticAnimalCount,i_herbivoreMinArea,i_carnivoreMinArea,i_aquaticMinArea))
	{
		case 0:
			i_herbivoreArea = i_herbivoreMinAnimalCount*i_herbivoreMinArea;break;
		case 1:
			i_carnivoreArea = i_carnivoreAnimalCount * i_carnivoreMinArea;break;
		case 2:
			i_aquaticArea = i_aquaticAnimalCount * i_aquaticMinArea;break;
		default: 
			return 0;
	}
	switch(minimumCost(i_herbivoreCost,i_carnivoreCost,i_aquaticCost,i_herbivoreMaxArea,i_carnivoreMaxArea,i_aquaticMaxArea))
	{
		case 0:
        	HMinCount = i_herbivoreMaxArea/i_herbivoreMinArea;
			i_herbivoreArea = HMinCount*i_herbivoreMinArea;break;
		case 1:
        	CMinCount = i_carnivoreMaxArea/i_carnivoreMinArea;
			i_carnivoreArea = CMinCount*i_carnivoreMinArea;break;
		case 2:
        	AMinCount = i_aquaticMaxArea/i_aquaticMinArea;
			i_aquaticArea = AMinCount*i_aquaticMinArea;break;
		default:
			return 0;
	}
	
	if(i_herbivoreArea==0)
		i_herbivoreArea = TotalArea - (i_carnivoreArea+i_aquaticArea);
	else if(i_carnivoreArea==0)
		i_carnivoreArea = TotalArea - (i_herbivoreArea+i_aquaticArea);
	else
		i_aquaticArea = TotalArea - (i_herbivoreArea+i_carnivoreArea);
	
	MinimumCost = i_herbivoreArea*i_herbivoreCost + i_carnivoreArea*i_carnivoreCost + i_aquaticArea*i_aquaticCost;
	std::cout<<MinimumCost;	
	
	return 0;
}

int maximumCost(int Hcost, int Ccost, int Acost, int Hcount,int Ccount, int Acount, int Harea, int Carea, int Aarea)
{
	if(Hcost>Ccost && Hcost>Acost)
		return 0;
	else if(Ccost>Hcost && Ccost>Acost)
		return 1;
	else if(Acost>Hcost && Acost>Ccost)
		return 2;
	else
	{
		int HTotal,CTotal,ATotal;
		if(Hcost == Ccost )
		{
			HTotal = Hcost*Hcount*Harea;
			CTotal = Ccost*Ccount*Carea;
			if(HTotal<CTotal)
				return 0;
			else
				return 1;
		}
		else if(Hcost == Acost)
		{
			HTotal = Hcost*Hcount*Harea;
			ATotal = Acost*Acount*Aarea;
			if(HTotal<ATotal)
				return 0;
			else
				return 2;
		}
		else if(Ccost == Acost)
		{
			CTotal = Ccost*Ccount*Carea;
			ATotal = Acost*Acount*Aarea;
			if(CTotal<ATotal)
				return 1;
			else
				return 2;
		}
		else 
		{
			HTotal = Hcost*Hcount*Harea;
			CTotal = Ccost*Ccount*Carea;
			ATotal = Acost*Acount*Aarea;
			
			if(HTotal<CTotal && HTotal < ATotal)
				return 0;
			else if(CTotal< HTotal && CTotal < ATotal)
				return 1;
			else
				return 2;
		}
		
	}		
}


int minimumCost(int Hcost, int Ccost, int Acost,int Harea,int Carea,int Aarea)
{
	if(Hcost<Ccost && Hcost<Acost)
		return 0;
	else if(Ccost<Hcost && Ccost<Acost)
		return 1;
	else if(Acost < Hcost && Acost < Ccost)
		return 2;
	else
	{
		int HTotal,CTotal,ATotal;
		if(Hcost == Ccost)
		{
			HTotal = Hcost*Harea;
			CTotal = Ccost*Carea;
			if(HTotal<CTotal)
				return 0;
			else
				return 1;
		}
		else if(Hcost == Acost)
		{
			HTotal = Hcost*Harea;
			ATotal = Acost*Aarea;
			if(HTotal<ATotal)
				return 0;
			else
				return 2;
		}
		else if(Ccost == Acost)
		{
			CTotal = Ccost*Carea;
			ATotal = Acost*Aarea;
			if(CTotal<ATotal)
				return 1;
			else
				return 2;
		}
		else 
		{
			HTotal = Hcost*Harea;
			CTotal = Ccost*Carea;
			ATotal = Acost*Aarea;
			
			if(HTotal<CTotal && HTotal < ATotal)
				return 0;
			else if(CTotal< HTotal && CTotal < ATotal)
				return 1;
			else
				return 2;
		}
		
	}
} 
