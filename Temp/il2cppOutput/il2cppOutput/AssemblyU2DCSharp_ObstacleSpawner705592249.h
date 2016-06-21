#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.GameObject[]
struct GameObjectU5BU5D_t3499186955;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"
#include "UnityEngine_UnityEngine_Vector23525329788.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ObstacleSpawner
struct  ObstacleSpawner_t705592249  : public MonoBehaviour_t3012272455
{
public:
	// UnityEngine.GameObject[] ObstacleSpawner::prefabs
	GameObjectU5BU5D_t3499186955* ___prefabs_2;
	// System.Single ObstacleSpawner::delay
	float ___delay_3;
	// System.Boolean ObstacleSpawner::active
	bool ___active_4;
	// UnityEngine.Vector2 ObstacleSpawner::delayRange
	Vector2_t3525329788  ___delayRange_5;

public:
	inline static int32_t get_offset_of_prefabs_2() { return static_cast<int32_t>(offsetof(ObstacleSpawner_t705592249, ___prefabs_2)); }
	inline GameObjectU5BU5D_t3499186955* get_prefabs_2() const { return ___prefabs_2; }
	inline GameObjectU5BU5D_t3499186955** get_address_of_prefabs_2() { return &___prefabs_2; }
	inline void set_prefabs_2(GameObjectU5BU5D_t3499186955* value)
	{
		___prefabs_2 = value;
		Il2CppCodeGenWriteBarrier(&___prefabs_2, value);
	}

	inline static int32_t get_offset_of_delay_3() { return static_cast<int32_t>(offsetof(ObstacleSpawner_t705592249, ___delay_3)); }
	inline float get_delay_3() const { return ___delay_3; }
	inline float* get_address_of_delay_3() { return &___delay_3; }
	inline void set_delay_3(float value)
	{
		___delay_3 = value;
	}

	inline static int32_t get_offset_of_active_4() { return static_cast<int32_t>(offsetof(ObstacleSpawner_t705592249, ___active_4)); }
	inline bool get_active_4() const { return ___active_4; }
	inline bool* get_address_of_active_4() { return &___active_4; }
	inline void set_active_4(bool value)
	{
		___active_4 = value;
	}

	inline static int32_t get_offset_of_delayRange_5() { return static_cast<int32_t>(offsetof(ObstacleSpawner_t705592249, ___delayRange_5)); }
	inline Vector2_t3525329788  get_delayRange_5() const { return ___delayRange_5; }
	inline Vector2_t3525329788 * get_address_of_delayRange_5() { return &___delayRange_5; }
	inline void set_delayRange_5(Vector2_t3525329788  value)
	{
		___delayRange_5 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
