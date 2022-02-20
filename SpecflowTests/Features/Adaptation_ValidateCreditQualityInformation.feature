Feature: EconomicEntityAdaptation_CheckStatusFor_CreditQualityInfo

@Adaptation_CreditQualityInfo
Scenario:  Economic Entity Adaptation : Validate CreditQualityInformation
	Given an object of data to be adapted
	| CounterpartyId | CounterpartyName       | NettingGroupName | RemainingMaturity | EffectiveMaturity | ExposureAtDefault | CreditRating |
	| 123            | Public Limited Company | Collateral2      | 6.26              | 723186.4          | 999999            | 1            |
	| 123            | Public Limited Company | Collateral1      | 8.32              | 502224.1          | 55000             | 1            |
	| 321            | Investment Bank        | Collateral3      | 1.47              | 27000             | 245110            | 2            |
	| 456            | Public PLC             | Collateral4      | 10.28             | 255000            | 245110            | 2            |
	And a list of eligible counterparties for the Adaptation
	| CounterpartyName       | NettingGroupName |
	| Public Limited Company | Collateral2      |
	| Investment Bank        | Collateral1      |
	And I am provided with the required Credit Quality information
	| Rating | CreditQuality | RiskWeightCreditQuality | RiskWeight |
	| 1      | 1             | 1                       | 0.7        |
	| 2      | 2             | 2                       | 0.8        |
	When I create the Economic Entity object
	Then I should be able to validate the CreditQualityInformation for each trade
	| CreditRating |
	| 1            |
	| 1            |
	| 2            |
	| 2            |