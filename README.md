# Mon Co. Unity Technical Test Documentation

## Overview

This project implements a simple modular card system with abilities in Unity 2022.3.47f1. Each card displays its name, health, and damage, and may possess one of three possible abilities: Heal, Buff, or Debuff. The system is designed to be extendable using ScriptableObjects, Interfaces, and clean MVC-inspited UI patterns.

## Implemented features

- **CardSO**: ScriptableObject defining a card (Name, Heal, Damage, and optional CardAbility).
- **ICardAbility**: Interface defining structure for card abilities, implemented by HealAbility, BuffAbility, and DebuffAbility.
- **Card**: Class that instantiates from CardSO, handles selection, and executes the ability.
- **CardVisual**: Display the card's data (Name, Health. Damage) on the UI.
- **Hand**: Spawn all available cards into the Hand area of the UI.
- **CardSelectionManager**: Singleton to manage selected card state.
- **CardDetailPanel**: Display the selected card's details and ability description.
- **HoverEffect**: Simple animation trigger for mouse hover using Animator.
- **UI Buttons**
  - **Execute**: Triggers the selected card's ability
  - **View Details**: Opens the detail panel with card data.

## How to add a new card

1. Create a new CardSo via 'Assets > Create > ScriptableObjects > Card'.
2. Fill in Name, Health, Damage.
3. (Optional) Assign an ability:
   - Create a new ScriptableObject (e.g., HealAbility).
   - Assign it to the CardSO's CardAbility field.
4. Assign the new CardSO to a card prefab instance via the new CardSO to a card prefab instane via the Hand setup script or manually instantiate in code.

## How to add a new ability

1. Create a new class that implements ICardAbility.
2. Override Execute() and GetDecription().
3. Create a ScriptableObject for it.
4. Assign it to any card via the CardSO.

## Time breakdowb

- Card system logic and design - 30 minutes
- ScriptableObject and ability structure - 1 hour
- Card prefab and visual setup - 1 hour
- UI logic - 1.5 hours
- Testing - 15 ~ 30 minutes

## Design decisions

- **Interface for Ability**: Promotes open/closed principle, enabling easy extention.
- **ScriptableObject for Abilities**: Allows reusability and easy tuning without recompiling.
- **MVC-inspired UI**: DetailPanel acts as View, SelectionManager as Controller, CardSO as Model.
- **Singleton for SelectionManager**: Simplifies centralized card selection handling.

## Limitation and areas of improment

- No drag and drop functionality yet. Would add it if expanded to support 3D table placement.
- Card abilities hardcoded in SOs. Could refactor to support more dynamic configuration or multiple abilities.
- No visual feedback or animation for Execution action yet.
- Minimal error handling/UI states. Would improve feedback when no card is selected.

## Reflections and Challenges

- I aimed to keep the system simple yet flexible by using ScriptableObjects and interfaces to manage card behaviour.
- One challenge was handling cards without abilities gracefully, which I addressed by using null-safe execution and fallback UI text.
- I would liked to add more visual polish for execution feedback and make the UI more interactive.
- My main goal is to ensure the code is extendable and readable within limited time I have.
- I also would like to enhance the detail panel with icons or richer descriptions to better reflect each card's ability.
