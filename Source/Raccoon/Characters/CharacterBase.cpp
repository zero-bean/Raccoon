#include "Characters/CharacterBase.h"
#include "GameFramework/CharacterMovementComponent.h"
#include "Components/CapsuleComponent.h"
#include "AbilitySystemComponent.h"
#include "GameplayTagContainer.h"

ACharacterBase::ACharacterBase()
{
	PrimaryActorTick.bCanEverTick = true;
	
	bUseControllerRotationPitch = false;
	bUseControllerRotationYaw = false;
	bUseControllerRotationRoll = false;
	
	GetCapsuleComponent()->InitCapsuleSize(42.0f, 96.0f);
	
	if (UCharacterMovementComponent* CMC = GetCharacterMovement())
	{
		CMC->bOrientRotationToMovement = true;
		CMC->RotationRate = FRotator(0.0f, 500.0f, 0.0f);
		CMC->JumpZVelocity = DefaultJumpVelocity;
		CMC->AirControl = 0.35f;
		CMC->MaxWalkSpeed = DefaultGroundSpeed;
		CMC->MinAnalogWalkSpeed = 20.0f;
		CMC->BrakingDecelerationWalking = 2000.f;
		CMC->BrakingDecelerationFalling = 500.f;
	}
}

UAbilitySystemComponent* ACharacterBase::GetAbilitySystemComponent() const
{
	return nullptr;
}

bool ACharacterBase::IsDead() const
{
	const UAbilitySystemComponent* ASC = GetAbilitySystemComponent();
	if (ASC)
	{
		static const FGameplayTag DeadTag = FGameplayTag::RequestGameplayTag(FName("Character.State.Dead"));
		return ASC->HasMatchingGameplayTag(DeadTag);
	}
	
	return false;
}



